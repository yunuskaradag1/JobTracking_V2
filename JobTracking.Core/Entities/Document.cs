using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core.Entities
{
   public class Document : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string ContentType { get; set; }
        public int TaskId { get; set; }
        public bool IsDeleted { get; set; }
        public int? TaskDetailId { get; set; }
    }
}
