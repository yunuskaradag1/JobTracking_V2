using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
   public class Task : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TaskStatusId { get; set; }
        public DateTime TargetFinishDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }
        public int? TotalWorkTime { get; set; }
        public int UserId { get; set; }
        public int ProjectId { get; set; }
        public string Priority { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastDateStudied { get; set; }
        public int TaskLevel { get; set; }
        public int CompanyId { get; set; }
        public bool IsWorkingOn { get; set; }
        public int CompanyUserId { get; set; }
        public DateTime DemandDate { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? LastStartActivityDate { get; set; }
        public int WorkTypeId { get; set; }
        public bool IsPublication { get; set; }
        public string ResponsibleTaskIds { get; set; }

        public int? ProjectVersionId { get; set; }
        public DateTime? PublicationDate { get; set; }
    }
}
