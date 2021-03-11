using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
   public class TownDto
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
