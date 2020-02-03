using City_Colombo_Institute.UI.Assignment;
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

namespace City_Colombo_Institute.UI
{
    public partial class StudentMainMenu : BaseUI
    {
        public StudentMainMenu()
        {
            InitializeComponent();
            this.SetFormName();

            lblStudentNo.Text = Entities.User.StudentNo;
            lblStudentName.Text = Entities.User.StudentName;
            lblStream.Text = Entities.User.Stream;
        }

        private void btnSubmissionAssignmnet_Click(object sender, EventArgs e)
        {
            SubmissionAssignment obj = new SubmissionAssignment();
            obj.Show();
        }

        private void btnViewSubmissionAssignmnet_Click(object sender, EventArgs e)
        {
            ViewAssignmentForStudent obj = new ViewAssignmentForStudent();
            obj.Show();
        }
    }
}
