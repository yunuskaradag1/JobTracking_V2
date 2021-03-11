using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
    public class ClaimRepository : BaseMainRepository<Claim>
    {
        public ClaimRepository(MainDbContext context)
         : base(context)
        {

        }
    }
}
