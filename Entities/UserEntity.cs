using System;

namespace Entities
{
    public class UserEntity
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserGroupID { get; set; }
        public bool IsSuperUser { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsActive { get; set; }
     
    }
}
