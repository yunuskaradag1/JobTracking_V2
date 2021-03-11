using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Core
{
  public  class ProjectVersionDto
    {
        public int ProjectId { get; set; }
        public bool IsDeleted { get; set; }
        public int VersionId { get; set; }
        public bool IsPublication { get; set; }
        public string IntermediateVersionNumber { get; set; }
        public DateTime? PublicationDate { get; set; }
        public DateTime? TargetPuplicationDate { get; set; }
        public DateTime? TestingStartDate { get; set; }
        public DateTime? TestingFinishDate { get; set; }
        public int? UserId { get; set; }
    }
}
