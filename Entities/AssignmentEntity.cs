using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AssignmentEntity
    {
        public int intAssignmentID { get; set; }
        public int intSubjectID { get; set; }
        public int intStreamID { get; set; }
        public int BatchID { get; set; }
        public string vcTitle { get; set; }
        public string SubjectName { get; set; }
        public string vcRemarks { get; set; }

        public DateTime dtGivenDate { get; set; }
        public DateTime dtSubmissionDate { get; set; }
        public string SubmitedDate { get; set; }

        public string vcSavePath { get; set; }
        public bool isActive { get; set; }
        public bool IsSubmited { get; set; }

        public string FilePath { get; set; }

        public int intStudentID { get; set; }

        public Boolean bIsLateSubmission { get; set; }

    }
}
