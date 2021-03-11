using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
    public class ToDoDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime TargetFinishDate { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public int ToDoLevel { get; set; }
        public bool IsDeleted { get; set; }
    }
}
