using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
   public class Claim : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ClaimGroupId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
