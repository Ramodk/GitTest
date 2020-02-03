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
    public partial class EditTeacher : BaseUI
    {
        int TeacherID;
        int SubjectID;

        private TeacherBAL objTeacherBAL;
        TeacherEntity objTeacherEntity;
        List<SubjectEntity> lstALreadySubjectEntity;
        List<SubjectEntity> lstSubjectEntity;


        public EditTeacher(int TeacherID)
        {
            InitializeComponent();
            this.SetFormName();
            this.TeacherID = TeacherID;
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

        private void EditTeacher_Load(object sender, EventArgs e)
        {
            objTeacherBAL = new TeacherBAL();
            objTeacherEntity = objTeacherBAL.GetTeacherDetails(TeacherID);
            txtFName.Text = objTeacherEntity.FName;
            txtLName.Text = objTeacherEntity.LName;
            txtAddress.Text = objTeacherEntity.Address;
            txtContact.Text = objTeacherEntity.ContactNo.ToString();

            dgvSubject.AutoGenerateColumns = false;
            dgvSubject.DataSource = objTeacherEntity.lstSubjectEntity.ToList();
            lstALreadySubjectEntity = objTeacherEntity.lstSubjectEntity;
            lstSubjectEntity = objTeacherEntity.lstSubjectEntity;

        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dgvSubject.Columns[e.ColumnIndex] == clmBtnRemove)
            {
                SubjectEntity objX = new SubjectEntity();
                objX.SubjectID = Convert.ToInt32(dgvSubject.Rows[e.RowIndex].Cells[clmSubjectID.Name].Value);
                objX.SubjectName = dgvSubject.Rows[e.RowIndex].Cells[clmSubject.Name].Value.ToString();
                lstSubjectEntity.RemoveAt(index);
                dgvSubject.DataSource = null;
                dgvSubject.DataSource = lstSubjectEntity.ToList();
            }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure Want to update Teacher ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                objTeacherEntity = new TeacherEntity();

                objTeacherEntity.FName = txtFName.Text.Trim();
                objTeacherEntity.LName = txtLName.Text.Trim();
                objTeacherEntity.Address = txtAddress.Text.Trim();
                objTeacherEntity.ContactNo = Convert.ToInt32(txtContact.Text.Trim());
                objTeacherEntity.TeacherID = this.TeacherID;
                objTeacherEntity.lstSubjectEntity = lstSubjectEntity;
                objTeacherEntity.lstAlreadySubjectEntity = lstALreadySubjectEntity;
                objTeacherEntity.UserID = Entities.User.UserID;


                objTeacherBAL = new TeacherBAL();
                bool result = objTeacherBAL.UpdateTeacher(objTeacherEntity);

                if (result == true)
                {
                    MessageBox.Show("Teacher Updated successfully !");
                    clear();
                }
                else
                {
                    MessageBox.Show("Can't Update");
                }
            }
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

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if (txtContact.Text.Trim().Length > 10)
                {
                    e.Handled = true;
                }
            }
          
        }
    }
}
