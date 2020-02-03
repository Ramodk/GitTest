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
    public partial class TeacherMainMenu : BaseUI
    {
        public TeacherMainMenu()
        {
            InitializeComponent();
            this.SetFormName();

            lblTeacherName.Text = Entities.User.TeacherName;
        }

        private void TeacherMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAssignment_Click(object sender, EventArgs e)
        {
            AddAssignment obj = new AddAssignment();
            obj.Show();
        }

        private void btnAssignmentMarking_Click(object sender, EventArgs e)
        {
            AssignmentMarking obj = new AssignmentMarking();
            obj.Show();
        }

        private void btnViewAssignmnet_Click(object sender, EventArgs e)
        {
            ViewAssignmentForTeacher obj = new ViewAssignmentForTeacher();
            obj.Show();
        }
    }
}
