using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class BatchEntity
    {
        public int BatchID { get; set; }
        public string BatchNo { get; set; }
        public DateTime StarDate { get; set; }
        public int StreamID { get; set; }
        public int UserID { get; set; } 
    }
}
