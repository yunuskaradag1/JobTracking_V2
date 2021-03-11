using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
    public class Note : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AboutId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
