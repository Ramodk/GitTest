using BAL;
using Colombo_City_Institute.UI.Common;
using Entities;
using System;
using System.Data;
using System.Windows.Forms;

namespace City_Colombo_Institute.UI.Student
{
    public partial class CreateStudent : BaseUI
    {
        private StudentEntity objStudentEntity;
        private StudentBAL objStudentBAL;
        private DataRow row;

        public CreateStudent()
        {
            InitializeComponent();
            this.SetFormName();
            SetFormName();
            GetAllStreams();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cmbStream.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a stream !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbBatch.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a batch !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNWI.Text.Trim() == "")
            {
                MessageBox.Show("Please enter name with initials !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtFullName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter full name !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please enter address !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtHome.Text.Trim() == "")
            {
                MessageBox.Show("Please enter home contact number !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMobile.Text.Trim() == "")
            {
                MessageBox.Show("Please enter mobile contact number !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Are You Sure Want to Create New Student ?", "CONFIRM", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    objStudentEntity = new StudentEntity
                    {
                        intStreamID = Convert.ToInt32(cmbStream.SelectedValue),
                        BatchID = Convert.ToInt32(cmbBatch.SelectedValue),
                        NameWithInitials = txtNWI.Text.Trim(),
                        FullName = txtFullName.Text.Trim(),
                        NIC = txtNIC.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        ContactHome = Convert.ToInt32(txtHome.Text.Trim()),
                        ContactMobile = Convert.ToInt32(txtMobile.Text.Trim())
                    };

                    objStudentBAL = new StudentBAL();
                    bool result = objStudentBAL.saveStudent(objStudentEntity);

                    if (result == true)
                    {
                        MessageBox.Show("Student created successfully ! \nAccount user name : "+ txtNIC.Text.Trim() + "\nPassword : 'NIC number first 4 digits'");
                        clear();
                    }
                    else
                    {
                        MessageBox.Show("Can't Register");

                    }

                }
            }
        }

        public void clear()
        {
            cmbBatch.SelectedIndex = -1;
            cmbStream.SelectedIndex = -1;
            txtNWI.Text = String.Empty;
            txtFullName.Text = String.Empty;
            txtAddress.Text = String.Empty;
            txtNIC.Text = String.Empty;
            txtHome.Text = String.Empty;
            txtMobile.Text = String.Empty;
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

        public void GetStreamWiseBatches()
        {
            objStudentBAL = new StudentBAL();
            DataTable dt = objStudentBAL.GetStreamWiseBatches(Convert.ToInt32(cmbStream.SelectedValue));
            cmbBatch.DataSource = dt;
            cmbBatch.DisplayMember = "BatchNo";
            cmbBatch.ValueMember = "BatchID";
            cmbBatch.SelectedIndex = -1;
        }

        private void cmbStream_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStreamWiseBatches();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbStream.SelectedIndex = -1;
            cmbBatch.DataSource = null;
            txtNWI.Text = "";
            txtFullName.Text = "";
            txtAddress.Text = "";
            txtHome.Text = "";
            txtMobile.Text = "";
            txtNIC.Text = "";

        }


        private void btnView_Click(object sender, EventArgs e)
        {
            frmViewStudent objView = new frmViewStudent();
            objView.ShowDialog();
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void CreateStudent_Load(object sender, EventArgs e)
        {

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
