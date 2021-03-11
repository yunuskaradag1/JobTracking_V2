using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
  public  class TaskDetail : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TaskStatusId { get; set; }
        public DateTime TargetFinishDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int? TotalWorkTime { get; set; }
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public DateTime? LastDateStudied { get; set; }
        public int TaskLevel { get; set; }
        public bool IsWorkingOn { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastStartActivityDate { get; set; }
        public int WorkTypeId { get; set; }
    }
}
