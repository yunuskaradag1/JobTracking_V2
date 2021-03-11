using JobTracking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Data.Repositories
{
   public class ClaimGroupRepository : BaseMainRepository<ClaimGroup>
    {
        public ClaimGroupRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
