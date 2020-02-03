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

namespace City_Colombo_Institute.UI.Assignment
{
    public partial class AssignmentMarking : BaseUI
    {
        StreamBAL objStreamBAL;
        TeacherBAL objTeacherBAL;
        AssignmentBAL objAssignmentBAL;

        public AssignmentMarking()
        {
            InitializeComponent();
            GetTeacherStream();
        }


        public void GetTeacherStream()
        {
            objStreamBAL = new StreamBAL();
            DataTable dt = objStreamBAL.GetTeacherStream(Convert.ToInt32(Entities.User.TeacherID));
            cmbStream.DataSource = dt;
            cmbStream.DisplayMember = "StreamName";
            cmbStream.ValueMember = "StreamID";
            cmbStream.SelectedIndex = -1;
        }

        public void GetTeacherSubject()
        {
            objTeacherBAL = new TeacherBAL();
            DataTable dt = objTeacherBAL.GetTeacherSubject(Convert.ToInt32(Entities.User.TeacherID),Convert.ToInt32(cmbStream.SelectedValue));
            cmbSubject.DataSource = dt;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "intSubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        private void cmbStream_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTeacherSubject();
        }

        private void GetBatchDetailsForStreamWise()
        {
            objAssignmentBAL = new AssignmentBAL();
            DataTable dt = objAssignmentBAL.GetBatchDetailsForStreamWise(Convert.ToInt32(cmbStream.SelectedValue));

            cmbBatch.DisplayMember = "BatchNo";
            cmbBatch.ValueMember = "BatchID";
            cmbBatch.SelectedIndex = -1;
        }

        private void cmbSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetBatchDetailsForStreamWise();
        }
    }


}
