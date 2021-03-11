using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
  public  class ProjectVersionRepository : BaseMainRepository<ProjectVersion>
    {
        public ProjectVersionRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
