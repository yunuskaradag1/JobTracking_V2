using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;


namespace JobTracking.Data.Repositories
{
  public  class MenuRepository : BaseMainRepository<Menu>
    {
        public MenuRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
