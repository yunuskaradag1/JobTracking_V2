using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
    public class UserRole : BaseEntity
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
