using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
   public class TownRepository : BaseMainRepository<Town>
    {
        public TownRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
