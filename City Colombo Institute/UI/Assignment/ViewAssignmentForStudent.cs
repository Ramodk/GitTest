using BAL;
using Colombo_City_Institute.UI.Common;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Colombo_Institute.UI.Assignment
{
    public partial class ViewAssignmentForStudent : BaseUI
    {

        AssignmentEntity objAssignmentEntity;
        private AssignmentBAL objAssignmentBAL;

        public ViewAssignmentForStudent()
        {
            InitializeComponent();
            this.SetFormName();
            GetAssignmentDetails();

            lblStudentNo.Text = Entities.User.StudentNo;
            lblStudentName.Text = Entities.User.StudentName;
            lblStream.Text = Entities.User.Stream;
        }

        public void GetAssignmentDetails()
        {

            objAssignmentBAL = new AssignmentBAL();
            List<AssignmentEntity> listAssignmentDetails = new List<AssignmentEntity>();

            listAssignmentDetails = objAssignmentBAL.GetAssignmentDetails();

            dgvAssignmentDetails.DataSource = null;
            dgvAssignmentDetails.AutoGenerateColumns = false;

            if (rbtComplete.Checked)
            {
                dgvAssignmentDetails.DataSource = listAssignmentDetails.FindAll(x => x.IsSubmited == true).ToList();
            }
            else if (rbtPending.Checked)
            {
                dgvAssignmentDetails.DataSource = listAssignmentDetails.FindAll(x => x.IsSubmited == false).ToList();
            } else if (rbtLate.Checked)
            {
                dgvAssignmentDetails.DataSource = listAssignmentDetails.FindAll(x => x.dtSubmissionDate < DateTime.Now.Date).ToList();
            }
            else
            {
                dgvAssignmentDetails.DataSource = listAssignmentDetails.ToList();
            }

            dgvAssignmentDetails.ClearSelection();

        }

        private void dgvAssignmentDetails_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvAssignmentDetails.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;

                if (Convert.ToBoolean(row.Cells[clmIsSubmited.Name].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(205, 220, 56);
                }
                else if (!Convert.ToBoolean(row.Cells[clmIsSubmited.Name].Value))
                {
                    if (Convert.ToDateTime(row.Cells[clmSubmissionDate.Name].Value) < DateTime.Now.Date)
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkRed;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else {
                        row.DefaultCellStyle.BackColor = Color.FromArgb(248, 115, 88);
                    }
                }
                else {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void rbtAll_CheckedChanged(object sender, EventArgs e)
        {
            GetAssignmentDetails();
        }

        private void rbtComplete_CheckedChanged(object sender, EventArgs e)
        {
            GetAssignmentDetails();
        }

        private void rbtPending_CheckedChanged(object sender, EventArgs e)
        {
            GetAssignmentDetails();
        }

        private void rbtLate_CheckedChanged(object sender, EventArgs e)
        {
            GetAssignmentDetails();
        }

        private void dgvAssignmentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssignmentDetails.Columns[e.ColumnIndex] == clmView)
            {
                string FilePath = dgvAssignmentDetails.Rows[e.RowIndex].Cells[clmFilePath.Name].Value.ToString();
                System.Diagnostics.Process.Start(FilePath);
            }
        }
    }
}
