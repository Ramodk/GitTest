using BAL;
using Colombo_City_Institute.UI.Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace City_Colombo_Institute.UI.User
{
    public partial class CreateUser : BaseUI
    {

        private UserEntity objUser;
        private UserBAL objUserBAL;

        public CreateUser()
        {
            //InitializeComponent();
            this.SetFormName();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter user name !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter password !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if (txtConfirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter confirm password !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
            }
            else if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                MessageBox.Show("Password & Confirm Password mismatched, Please try again !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                txtPassword.Text = null;
                txtConfirmPassword.Text = null;
            }
            else if (cmbUserGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user group !", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    objUserBAL = new UserBAL();
                    if (CheckAlreadyCreated(txtUserName.Text.Trim()))
                    {
                        MessageBox.Show("This user name is already exist. Please try another user name !", "ALREADY EXIST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }



                    objUser = new UserEntity();
                    objUser.UserName = txtUserName.Text.Trim();
                    objUser.Password = txtPassword.Text.Trim();
                    objUser.UserGroupID = Convert.ToInt32(cmbUserGroup.SelectedValue);
                    objUser.IsSuperUser = false;

                    if (Convert.ToInt32(cmbUserGroup.SelectedValue) == 1)
                    {
                        objUser.IsSuperUser = true;
                    }

                    if (objUserBAL.CreateUser(objUser))
                    {
                        MessageBox.Show("New User Created Successfully !", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearItems();
                    }
                    else
                    {
                        MessageBox.Show("Data Saving Error !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool CheckAlreadyCreated(string UserName)
        {
            objUserBAL = new UserBAL();
            return objUserBAL.CheckAlreadyCreated(UserName);
        }

        private void ClearItems()
        {
            txtUserName.Text = null;
            txtPassword.Text = null;
            txtConfirmPassword.Text = null;
            cmbUserGroup.SelectedIndex = -1;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearItems();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            LoadUserGroups();
        }

        private void LoadUserGroups()
        {
            objUserBAL = new UserBAL();
            List<UserGroupEntity> lst = objUserBAL.GetUserGroups();

            lst = lst.FindAll(x => x.UserGroupID != 3);

            cmbUserGroup.DataSource = lst;
            cmbUserGroup.DisplayMember = "UserGroup";
            cmbUserGroup.ValueMember = "UserGroupID";
            cmbUserGroup.SelectedIndex = -1;
        }
    }
}
