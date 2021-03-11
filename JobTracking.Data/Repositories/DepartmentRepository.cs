using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
    public class DepartmentRepository : BaseMainRepository<Department>
    {
        public DepartmentRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
