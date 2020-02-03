using BAL;
using Colombo_City_Institute.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Colombo_Institute.UI.Subject
{
    public partial class AddSubject : BaseUI
    {
        StudentBAL objStudentBAL;
        StreamBAL objStreamBAL;
        int SubjectID;

        public AddSubject()
        {
            InitializeComponent();
            this.SetFormName();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStream.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a stream !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtSubject.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Subject !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are You Sure Want to add New Subject ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    objStreamBAL = new StreamBAL();
                    bool result = objStreamBAL.SaveSubject(Convert.ToInt32(cmbStream.SelectedValue), txtSubject.Text.ToString());

                    if (result == true)
                    {
                        GetSubjects();
                        MessageBox.Show("Subject added successfully !");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Error !");
                    }
                }
            }
        }
        private void GetAllStreams()
        {
            objStudentBAL = new StudentBAL();
            DataTable dt = objStudentBAL.GetAllStreams();
            cmbStream.DataSource = dt;
            cmbStream.DisplayMember = "StreamName";
            cmbStream.ValueMember = "StreamID";
            cmbStream.SelectedIndex = -1;
        }

        private void AddSubject_Load(object sender, EventArgs e)
        {
            GetAllStreams();
        }

        public void GetSubjects()
        {
            objStudentBAL = new StudentBAL();
            DataTable dt = objStudentBAL.GetSubjects(Convert.ToInt32(cmbStream.SelectedValue));

            dgvStreamDetails.DataSource = dt;
        }

        private void cmbStream_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSubjects();
        }

        private void dgvStreamDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStreamDetails.Columns[e.ColumnIndex] == clmbtnEdit)
            {
                SubjectID = Convert.ToInt32(dgvStreamDetails.Rows[e.RowIndex].Cells[clmSubjectID.Name].Value);

                EditSubject objfrm = new EditSubject(SubjectID);
                objfrm.ShowDialog();
                GetSubjects();
            }
        }
        public void clear()
        {
            cmbStream.SelectedIndex = -1;
            txtSubject.Text = string.Empty;
        }
    }
}
