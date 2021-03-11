using JobTracking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Data.Repositories
{
    public class ActivityRepository : BaseMainRepository<Activity>
    {
        public ActivityRepository(MainDbContext context)
            : base(context)
        {

        }

    }
}
