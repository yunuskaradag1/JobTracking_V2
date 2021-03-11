using JobTracking.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobTracking.Data
{
    public class BaseMainRepository<T> : BaseRepository<T, MainDbContext>
            where T : BaseEntity
    {
        public BaseMainRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
