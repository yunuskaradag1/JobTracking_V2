using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
   public class UserDocumentDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string ContentType { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
