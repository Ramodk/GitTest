using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StudentEntity
    {
        public string StudentNo { get; set; }
        public int StudentID { get; set; }
        public string NameWithInitials { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int ContactHome { get; set; }
        public int ContactMobile { get; set; }
        public int intStreamID { get; set; }
        public int BatchID { get; set; }
        public string NIC { get; set; }

        public string Batch { get; set; }
        public string Stream { get; set; }

        public int CurrentBatchID { get; set; }
    }
}
