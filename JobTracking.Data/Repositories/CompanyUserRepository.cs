using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
  public  class CompanyUserRepository : BaseMainRepository<CompanyUser>
    {
        public CompanyUserRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
