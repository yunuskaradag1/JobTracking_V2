using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
   public class Activity : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TaskDetailId { get; set; }
        public string ActivityStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int? TotalWorkTime { get; set; }
        public int? LastTaskStatusId { get; set; }
        public bool IsDeleted { get; set; }

    }
}
