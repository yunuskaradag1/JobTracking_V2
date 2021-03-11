using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
  public  class CountryDto
    {    
        public string Code { get; set; }
        public string PhoneCode { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
