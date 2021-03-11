using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
  public  class RoleClaim : BaseEntity

    {
        public int RoleId { get; set; }
        public int ClaimId { get; set; }
    }
}
