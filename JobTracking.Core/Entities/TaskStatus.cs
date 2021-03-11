using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
   public class TaskStatus : BaseEntity
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
