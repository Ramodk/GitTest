using City_Colombo_Institute.UI.Assignment;
using City_Colombo_Institute.UI.Stream;
using City_Colombo_Institute.UI.Student;
using City_Colombo_Institute.UI.Subject;
using City_Colombo_Institute.UI.Teacher;
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
    public partial class MainMenu : BaseUI
    {
        public MainMenu()
        {
            InitializeComponent();
            this.SetFormName();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTeacher obj = new CreateTeacher();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmViewStudent objView = new frmViewStudent();
            objView.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateTeacher objCreate = new CreateTeacher();
            objCreate.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAddStream obj = new frmAddStream();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewTeacher obj = new ViewTeacher();
            obj.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddSubject obj = new AddSubject();
            obj.Show();
        }

        private void btnas_Click(object sender, EventArgs e)
        {
            AddAssignment obj = new AddAssignment();
            obj.Show();
        }

        private void btnaddstu_Click(object sender, EventArgs e)
        {
            CreateStudent obj = new CreateStudent();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewAssignmentForTeacher obj = new ViewAssignmentForTeacher();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddBatch obj = new AddBatch();
            obj.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SubmissionAssignment obj = new SubmissionAssignment();
            obj.Show();
        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            AssignmentMarking obj = new AssignmentMarking();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddAssignment obj = new AddAssignment();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ViewAssignmentForTeacher obj = new ViewAssignmentForTeacher();
            obj.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            ViewAssignmentForStudent obj = new ViewAssignmentForStudent();
            obj.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
          
        }
    }
}
