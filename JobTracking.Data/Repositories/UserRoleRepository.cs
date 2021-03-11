using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
   public class UserRoleRepository : BaseMainRepository<UserRole>
    {
        public UserRoleRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
