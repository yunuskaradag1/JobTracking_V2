using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
    public class TaskStatusDto
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
