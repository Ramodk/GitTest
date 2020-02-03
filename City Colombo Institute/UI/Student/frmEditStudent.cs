using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using Colombo_City_Institute.UI.Common;
using Entities;

namespace City_Colombo_Institute.UI.Student
{
    public partial class frmEditStudent : BaseUI
    {
        StudentEntity objStudentEntity;
        StudentBAL objStudentBAL;
        DataRow row;
        private int StudentID { get; set; }
        private int streamID { get; set; }
        private int BatchID { get; set; }

        public frmEditStudent(int studentID)
        {
            InitializeComponent();
            this.SetFormName();
            StudentID = studentID;
            // StudentID = Convert.ToInt32(StudentID);
            GetOneStudentDetails();
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            if (Convert.ToInt32(cmbBatch.SelectedValue) != BatchID)
            {
                dr = MessageBox.Show("Are you sure want to batch transfer in this student ?", "BATCH TRANSFER - CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
            else {
                dr = MessageBox.Show("Are You Sure Want to Edit Student ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            }


            if (dr == DialogResult.Yes)
            {
                objStudentEntity = new StudentEntity();

                objStudentEntity.StudentID = StudentID;
                objStudentEntity.intStreamID = streamID;
                objStudentEntity.BatchID = Convert.ToInt32(cmbBatch.SelectedValue);
                objStudentEntity.CurrentBatchID = BatchID;
                objStudentEntity.NameWithInitials = txtNWI.Text.Trim();
                objStudentEntity.FullName = txtFullName.Text.Trim();
                objStudentEntity.NIC = txtNIC.Text.Trim();
                objStudentEntity.Address = txtAddress.Text.Trim();
                objStudentEntity.ContactHome = Convert.ToInt32(txtHome.Text.Trim());
                objStudentEntity.ContactMobile = Convert.ToInt32(txtMobile.Text.Trim());
                

                objStudentBAL = new StudentBAL();
                bool result = objStudentBAL.updateStudent(objStudentEntity);

                if (result == true)
                {
                    MessageBox.Show("Student Updated Successfully !");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Can't Update !");
                }
            }
           
        }
        public void GetStreamWiseBatches()
        {
            objStudentBAL = new StudentBAL();
            DataTable dt = objStudentBAL.GetStreamWiseBatches(Convert.ToInt32(streamID));
            cmbBatch.DataSource = dt;
            cmbBatch.DisplayMember = "BatchNo";
            cmbBatch.ValueMember = "BatchID";
           // cmbBatch.SelectedIndex = -1;
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            GetStreamWiseBatches();
            cmbBatch.SelectedValue = BatchID;
        }
        public void GetOneStudentDetails()
        {
            objStudentBAL = new StudentBAL();
            DataSet ds = objStudentBAL.GetOneStudentDetails(StudentID);


            if (ds.Tables[0].Rows.Count >=0)
            {
                txtStream.Text = ds.Tables[0].Rows[0]["StreamName"].ToString();
                txtNWI.Text = ds.Tables[0].Rows[0]["NameWithInitials"].ToString();
                txtFullName.Text = ds.Tables[0].Rows[0]["FullName"].ToString();
                txtNIC.Text = ds.Tables[0].Rows[0]["NIC"].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                txtHome.Text = ds.Tables[0].Rows[0]["ContactHome"].ToString();
                txtMobile.Text = ds.Tables[0].Rows[0]["ContactMobile"].ToString();
                streamID = Convert.ToInt32(ds.Tables[0].Rows[0]["intStreamID"].ToString());
                BatchID = Convert.ToInt32(ds.Tables[0].Rows[0]["intBatchID"].ToString());

            }
        }

        private void txtHome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
