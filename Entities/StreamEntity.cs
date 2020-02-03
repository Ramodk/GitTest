using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class StreamEntity
    {
        public int StreamID { get; set; }
        public string StreamName { get; set; }
        public string ShortCode { get; set; }
        public bool IsActive { get; set; }
    }
}
