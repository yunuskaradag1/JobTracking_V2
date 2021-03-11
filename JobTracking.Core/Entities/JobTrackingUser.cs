using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobTracking.Core.Entities
{
  public  class JobTrackingUser : IdentityUser<int>
    {
        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        public int UserType { get; set; }

        [StringLength(100)]
        public string Role { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }
    }
}
