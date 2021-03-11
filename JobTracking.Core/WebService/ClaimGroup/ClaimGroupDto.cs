using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
  public  class ClaimGroupDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
    }
}
