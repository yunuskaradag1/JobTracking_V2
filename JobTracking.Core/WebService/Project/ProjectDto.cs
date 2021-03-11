using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
  public  class ProjectDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CompanyId { get; set; }
        public bool IsDeleted { get; set; }
        public int VersionId { get; set; }
    }
}
