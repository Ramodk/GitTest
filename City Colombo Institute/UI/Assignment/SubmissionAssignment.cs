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

namespace City_Colombo_Institute.UI.Assignment
{
    public partial class SubmissionAssignment : BaseUI
    {
        AssignmentBAL objAssignmentBAL;
        private DataRow row;
        int intAssignmentID;

        public SubmissionAssignment()
        {
            InitializeComponent();
            this.SetFormName();
            GetSubjectForStudentWise();
        }


        public void GetSubjectForStudentWise()
        {
            objAssignmentBAL = new AssignmentBAL();
            DataTable dt = objAssignmentBAL.GetSubjectForStudentWise(Convert.ToInt32(Entities.User.StudentID));
            cmbSubject.DataSource = dt;
    
            row = dt.NewRow();
            row["SubjectID"] = 0;
            row["SubjectName"] = " -- All --";
 
            dt.Rows.Add(row);

            cmbSubject.DataSource = dt;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = (dt.Rows.Count) - 1;

        }

        public void GetAssignmentDeatilsForSubjectWise()
        {
            objAssignmentBAL = new AssignmentBAL();
            List<AssignmentEntity> listAssignmentDetails = new List<AssignmentEntity>();

            listAssignmentDetails = objAssignmentBAL.GetAssignmentDeatilsForSubjectWise(Convert.ToInt32(cmbSubject.SelectedValue));

            dgvAssignmentDetails.DataSource = null;
            dgvAssignmentDetails.AutoGenerateColumns = false;

            dgvAssignmentDetails.DataSource = listAssignmentDetails.ToList();


        }

        private void cmbSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetAssignmentDeatilsForSubjectWise();
        }

        private void dgvAssignmentDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAssignmentDetails.Columns[e.ColumnIndex] == clmView)
            {
                string FilePath = dgvAssignmentDetails.Rows[e.RowIndex].Cells[clmFilePath.Name].Value.ToString();
                System.Diagnostics.Process.Start(FilePath);
            }
            if (dgvAssignmentDetails.Columns[e.ColumnIndex] == clmSubmit)
            {
                intAssignmentID = Convert.ToInt32(dgvAssignmentDetails.Rows[e.RowIndex].Cells[clmAssignmentID.Name].Value);

                AddStudentAssignmentForSubmission obj = new AddStudentAssignmentForSubmission(intAssignmentID,cmbSubject.Text.Trim());
                obj.ShowDialog();
            }
        }
    }
}
