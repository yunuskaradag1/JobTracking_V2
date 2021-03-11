using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
    public class TaskStatusRepository : BaseMainRepository<TaskStatus>
    {
        public TaskStatusRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
