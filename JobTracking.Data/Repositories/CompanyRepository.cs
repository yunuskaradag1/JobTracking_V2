using JobTracking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Data.Repositories
{
    public class CompanyRepository : BaseMainRepository<Company>
    {
        public CompanyRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
