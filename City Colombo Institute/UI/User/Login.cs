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

namespace City_Colombo_Institute.UI.User
{
    public partial class Login : Form
    {
        UserBAL objUserBAL;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() == "")
            {
                txtUserName.Focus();
                MessageBox.Show("Please Enter User Name !");
            }
            else if (txtPassword.Text.Trim() == "")
            {
                txtPassword.Focus();
                MessageBox.Show("Please Enter Password !");
            }
            else {
                objUserBAL = new UserBAL();
                DataRow result = objUserBAL.CheckUserAccount(txtUserName.Text.Trim(),txtPassword.Text.Trim());

                if (result != null)
                {
                    if (Entities.User.UserGroupID == 1) // Admin
                    {
                        MainMenu obj = new MainMenu();
                        obj.Show();
                        this.Hide();
                    }
                    else if (Entities.User.UserGroupID == 2) // Teacher
                    {
                        TeacherMainMenu obj = new TeacherMainMenu();
                        obj.Show();
                        this.Hide();
                    }
                
                    else if (Entities.User.UserGroupID == 3) // Student
                    {
                        StudentMainMenu obj = new StudentMainMenu();
                        obj.Show();
                        this.Hide();
                    }
              
                }
                else
                {
                    MessageBox.Show("Please Enter Correct User Name or Password !");
                }
            }
        }
    }
}
