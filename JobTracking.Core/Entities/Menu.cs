using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
   public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public string Claim { get; set; }
        public int? ParentId { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public string DataTarget { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

    }
}
