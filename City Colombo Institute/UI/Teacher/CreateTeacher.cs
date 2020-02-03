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

namespace City_Colombo_Institute.UI.Teacher
{
    public partial class CreateTeacher : BaseUI
    {

        TeacherEntity objTecherEntity;
        TeacherBAL objTeacherBAL;

        List<SubjectEntity> lstSubjectEntity;

        public CreateTeacher()
        {
            InitializeComponent();
            this.SetFormName();
        }

        private void CreateTeacher_Load(object sender, EventArgs e)
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

        public void clear()
        {
            txtFName.Text = String.Empty;
            txtLName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtContact.Text = String.Empty;
            cmbStream.SelectedIndex = -1;
            cmbSubject.DataSource = null;
            lstSubjectEntity = null;
            dgvSubject.DataSource = null;

        }
      
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtFName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter first name  !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtLName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter last name !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please enter address !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtContact.Text.Trim() == "")
            {
                MessageBox.Show("Please enter contact number !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are You Sure Want to Create New Teacher ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    objTecherEntity = new TeacherEntity();
                    objTecherEntity.FName = txtFName.Text.Trim();
                    objTecherEntity.LName = txtLName.Text.Trim();
                    objTecherEntity.Address = txtAddress.Text.Trim();
                    objTecherEntity.ContactNo = Convert.ToInt32(txtContact.Text.Trim());
                    

                    objTecherEntity.lstSubjectEntity = lstSubjectEntity;

                    objTeacherBAL = new TeacherBAL();
                    bool result = objTeacherBAL.saveTeacher(objTecherEntity);

                    if (result == true)
                    {
                        MessageBox.Show("Teacher created successfully !");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Can't Register");
                    }
                }
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (lstSubjectEntity == null)
            {
                lstSubjectEntity = new List<SubjectEntity>();
            }

            if (lstSubjectEntity.Find(x => x.SubjectID == Convert.ToInt32(cmbSubject.SelectedValue)) != null)
            {
                MessageBox.Show("You can't select duplicate subject!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SubjectEntity objSubjectEntity = new SubjectEntity();
            objSubjectEntity.SubjectID = Convert.ToInt32(cmbSubject.SelectedValue);
            objSubjectEntity.SubjectName = cmbSubject.Text.ToString();

            lstSubjectEntity.Add(objSubjectEntity);

            dgvSubject.AutoGenerateColumns = false;
            dgvSubject.DataSource = null;
            dgvSubject.DataSource = lstSubjectEntity;
        }
    }
}
