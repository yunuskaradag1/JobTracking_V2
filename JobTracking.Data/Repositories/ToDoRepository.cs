using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
   public class ToDoRepository : BaseMainRepository<ToDo>
    {
        public ToDoRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
