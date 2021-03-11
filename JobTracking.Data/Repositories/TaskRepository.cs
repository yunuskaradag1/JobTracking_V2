using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
   public class TaskRepository : BaseMainRepository<Task>
    {
        public TaskRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
