using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
   public class Country : BaseEntity
    {
        public string Code { get; set; }
        public string PhoneCode { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
