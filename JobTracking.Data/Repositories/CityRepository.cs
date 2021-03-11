using JobTracking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Data.Repositories
{
  public  class CityRepository : BaseMainRepository<City>
    {
        public CityRepository(MainDbContext context)
              : base(context)
        {

        }
    }
}
