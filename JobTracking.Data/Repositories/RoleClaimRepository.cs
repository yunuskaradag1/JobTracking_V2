using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
  public class RoleClaimRepository : BaseMainRepository<RoleClaim>
    {
        public RoleClaimRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
