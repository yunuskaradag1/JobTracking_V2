using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
  public  class RoleRepository : BaseMainRepository<Role>
    {
        public RoleRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
