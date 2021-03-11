using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
  public  class ClaimGroup : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
    }
}
