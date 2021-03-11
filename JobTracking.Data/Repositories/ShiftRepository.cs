using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
  public  class ShiftRepository : BaseMainRepository<Shift>
    {
        public ShiftRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
