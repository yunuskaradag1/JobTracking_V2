using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
  public  class Shift : BaseEntity
    {
            
        public DateTime Startdate { get; set; }
        public DateTime FinishDate { get; set; }
        public string WorkArea { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
