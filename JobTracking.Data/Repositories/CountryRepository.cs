using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
    public class CountryRepository : BaseMainRepository<Country>
    {
        public CountryRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
