using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
    public class WorkTypeDefinitionDto
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsProjectVersion { get; set; }
    }
}
