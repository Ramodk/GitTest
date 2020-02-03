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

namespace City_Colombo_Institute.UI.Teacher
{
    public partial class ViewTeacher : BaseUI
    {
        private TeacherBAL objTeacherBAL;
        int TeacherID;

        public ViewTeacher()
        {
            InitializeComponent();
            this.SetFormName();
        }

        private void ViewTeacher_Load(object sender, EventArgs e)
        {
            GetAllStreams();
        }
        private void GetAllStreams()
        {
            objTeacherBAL = new TeacherBAL();
            DataTable dt = objTeacherBAL.GetAllStreams();
            cmbStream.DataSource = dt;
            cmbStream.DisplayMember = "StreamName";
            cmbStream.ValueMember = "StreamID";
            cmbStream.SelectedIndex = -1;
        }

        private void cmbStream_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStreamWiseSubject();
        }

        public void GetStreamWiseSubject()
        {
            objTeacherBAL = new TeacherBAL();
            DataTable dt = objTeacherBAL.GetStreamWiseSubject(Convert.ToInt32(cmbStream.SelectedValue));
            cmbSubject.DataSource = dt;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        private void cmbSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTeacherDetailsForSubjectWise();
        }

        public void GetTeacherDetailsForSubjectWise()
        {
            objTeacherBAL = new TeacherBAL();
            List<TeacherEntity> listTeacherDetails = new List<TeacherEntity>();
            listTeacherDetails = objTeacherBAL.GetTeacherDetailsForSubjectWise(Convert.ToInt32(cmbSubject.SelectedValue));

            dgvTeacherDetails.DataSource = null;
            dgvTeacherDetails.AutoGenerateColumns = false;
            dgvTeacherDetails.DataSource = listTeacherDetails;
        }

        private void dgvStudentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTeacherDetails.Columns[e.ColumnIndex] == clmbtnEdit)
            {
                TeacherID = Convert.ToInt32(dgvTeacherDetails.Rows[e.RowIndex].Cells[clmTeacherID.Name].Value);

                EditTeacher objfrm = new EditTeacher(TeacherID);
                objfrm.ShowDialog();
            }
            else if (dgvTeacherDetails.Columns[e.ColumnIndex] == clmbtnDeactivate)
            {
                TeacherID = Convert.ToInt32(dgvTeacherDetails.Rows[e.RowIndex].Cells[clmTeacherID.Name].Value);

                DialogResult dr = MessageBox.Show("Are you sure want to deactivate in this student ?", "CONFIRMATION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    objTeacherBAL = new TeacherBAL();
                    bool result = objTeacherBAL.DeactivateTeacher(TeacherID);

                    if (result)
                    {
                        GetTeacherDetailsForSubjectWise();
                        MessageBox.Show("Successfully Deactivated !");

                    }
                    else
                    {
                        MessageBox.Show("Teacher Deactivate Process Error !");
                    }
                }
              
            }
        }
    }
}
