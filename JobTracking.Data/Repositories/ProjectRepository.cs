using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
  public  class ProjectRepository : BaseMainRepository<Project>
    {
        public ProjectRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
