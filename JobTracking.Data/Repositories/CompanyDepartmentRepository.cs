using JobTracking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Data.Repositories
{
    public class CompanyDepartmentRepository : BaseMainRepository<CompanyDepartment>
    {
        public CompanyDepartmentRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
