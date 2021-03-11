using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
  public  class CompanyDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public string Youtube { get; set; }
        public bool IsDeleted { get; set; }
    }
}
