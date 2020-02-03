using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TeacherEntity
    {
        public int TeacherID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int ContactNo { get; set; }

        public List<SubjectEntity> lstSubjectEntity { get; set; }
        public List<SubjectEntity> lstAlreadySubjectEntity { get; set; }

        public int UserID { get; set; }


    }
}
