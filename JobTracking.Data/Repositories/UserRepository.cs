using JobTracking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Data.Repositories
{
   public class UserRepository : BaseMainRepository<User>
    {
        public UserRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
