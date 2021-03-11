using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
   public class UserRole
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
