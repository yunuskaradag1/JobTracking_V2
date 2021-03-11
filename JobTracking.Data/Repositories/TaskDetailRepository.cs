using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
   public class TaskDetailRepository : BaseMainRepository<TaskDetail>
    {
        public TaskDetailRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
