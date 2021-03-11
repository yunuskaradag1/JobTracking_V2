using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
    public class NoteDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int AboutId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
