using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
 public  class ClaimDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ClaimGroupId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
