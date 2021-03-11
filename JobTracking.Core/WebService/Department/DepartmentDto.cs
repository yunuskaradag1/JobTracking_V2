using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
    public class DepartmentDto
    {
        public string Name { get; set; }
        public int? ResponsibleUserId { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
