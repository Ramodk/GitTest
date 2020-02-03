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

namespace City_Colombo_Institute.UI.Stream
{
    public partial class AddBatch : BaseUI
    {
        StudentBAL objStudentBAL;
        AssignmentBAL objAssignmentBAL;

        public AddBatch()
        {
            InitializeComponent();
            this.SetFormName();
            GetAllStreams();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStream.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a stream !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtBatchNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Batch No !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are You Sure Want to add New batch ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    objAssignmentBAL = new AssignmentBAL();
                    bool result = objAssignmentBAL.SaveBatch(Convert.ToInt32(cmbStream.SelectedValue), txtBatchNo.Text.ToString(), Convert.ToDateTime(dtStartDate.Value)) ;

                    if (result == true)
                    {
                        GetBatchDetailsForStreamWise();
                        MessageBox.Show("Batch added successfully !");
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

        private void GetBatchDetailsForStreamWise()
        {
            objAssignmentBAL = new AssignmentBAL();
            DataTable dt = objAssignmentBAL.GetBatchDetailsForStreamWise(Convert.ToInt32(cmbStream.SelectedValue));

            dgvStreamDetails.AutoGenerateColumns = false;
            dgvStreamDetails.DataSource = dt;
        }

        private void cmbStream_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBatchDetailsForStreamWise();
        }
        private void clear()
        {
            cmbStream.SelectedIndex = -1;
            txtBatchNo.Text = string.Empty;
        }

    }
}
