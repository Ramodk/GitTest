using BAL;
using Colombo_City_Institute.UI.Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace City_Colombo_Institute.UI.Student
{
    public partial class frmViewStudent : BaseUI
    {
        private StudentEntity objStudentEntity;
        private StudentBAL objStudentBAL;
        private DataRow row;
        private int studentID;

        public frmViewStudent()
        {
            InitializeComponent();
            this.SetFormName();
            SetFormName();
            GetAllStreams();
            GetStreamWiseBatches();
        }
        private void GetAllStreams()
        {

            objStudentBAL = new StudentBAL();
            DataTable dt = objStudentBAL.GetAllStreams();
            row = dt.NewRow();
            row["StreamID"] = 0;
            row["StreamName"] = " -- All --";
            row["ShortCode"] = "";
            row["IsActive"] = 1;

            dt.Rows.Add(row);

            cmbStream.DataSource = dt;
            cmbStream.DisplayMember = "StreamName";
            cmbStream.ValueMember = "StreamID";
            cmbStream.SelectedIndex = (dt.Rows.Count) - 1;
        }
        public void GetStreamWiseBatches()
        {
            objStudentBAL = new StudentBAL();
            DataTable dt = objStudentBAL.GetStreamWiseBatches(Convert.ToInt32(cmbStream.SelectedValue));
            row = dt.NewRow();
            row["BatchID"] = 0;
            row["BatchNo"] = " -- All --";
            //row["StartDate"] = "";

            dt.Rows.Add(row);

            cmbBatch.DataSource = dt;
            cmbBatch.DisplayMember = "BatchNo";
            cmbBatch.ValueMember = "BatchID";
            cmbBatch.SelectedIndex = (dt.Rows.Count) - 1;
        }

        public void GetStudentDetails()
        {
            objStudentBAL = new StudentBAL();
            List<StudentEntity> listStudentDetails = new List<StudentEntity>();
            listStudentDetails = objStudentBAL.GetStudentDetails(Convert.ToInt32(cmbBatch.SelectedValue), Convert.ToInt32(cmbStream.SelectedValue));

            dgvStudentDetails.DataSource = null;
            dgvStudentDetails.AutoGenerateColumns = false;
            dgvStudentDetails.DataSource = listStudentDetails;

        }


        private void frmViewStudent_Load(object sender, EventArgs e)
        {
            GetStudentDetails();
        }

        private void dgvStudentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvStudentDetails.Columns[e.ColumnIndex] == clmbtnEdit)
            {
                studentID = Convert.ToInt32(dgvStudentDetails.Rows[e.RowIndex].Cells[clmStudentID.Name].Value);

                frmEditStudent objfrm = new frmEditStudent(studentID);
                //objfrm.GetOneStudentDetails(StudentID);
                objfrm.ShowDialog();
            }
            else if (dgvStudentDetails.Columns[e.ColumnIndex] == clmbtnDeactivate)
            {

                DialogResult dr = MessageBox.Show("Are you sure want to deactivate in this student ?", "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    objStudentBAL = new StudentBAL();
                    studentID = Convert.ToInt32(dgvStudentDetails.Rows[e.RowIndex].Cells[clmStudentID.Name].Value);
                    bool result = objStudentBAL.DeactivateStudent(studentID);

                    if (result)
                    {
                        GetStudentDetails();
                        MessageBox.Show("Successfully Deactivated !");
                    
                    }
                    else
                    {
                        MessageBox.Show("Student Deactivate Process Error !");
                    }
                }
            }

            //    if (dgvStudentDetails.Rows[e.RowIndex].Cells[clmbtnEdit.Name].Value != null)
            //{
            //    MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            //}





            //////
            //DataGridView senderGrid = (DataGridView)sender;

            //if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            //{
            //    studentID = Convert.ToInt32(dgvStudentDetails.Rows[e.RowIndex].Cells[clmStudentID.Name].Value);

            //    frmEditStudent objfrm = new frmEditStudent(studentID);
            //    //objfrm.GetOneStudentDetails(StudentID);
            //    objfrm.ShowDialog();
            //}

        }

        private void cmbStream_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //  GetStreamWiseBatches(Convert.ToInt32(cmbStream.SelectedValue));
            GetStreamWiseBatches();
            GetStudentDetails();

        }

        private void cmbBatch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudentDetails();
        }
    }
}
