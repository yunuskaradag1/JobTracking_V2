using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
  public class City : BaseEntity
    {
        public int CountryId { get; set; }
        public string Code { get; set; }
        public string PhoneCode { get; set; }
        public bool IsDeleted { get; set; }
    }
}
