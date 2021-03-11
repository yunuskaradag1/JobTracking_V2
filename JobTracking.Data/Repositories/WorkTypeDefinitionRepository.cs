using System;
using System.Collections.Generic;
using System.Text;
using JobTracking.Core.Entities;

namespace JobTracking.Data.Repositories
{
   public class WorkTypeDefinitionRepository : BaseMainRepository<WorkTypeDefinition>
    {
        public WorkTypeDefinitionRepository(MainDbContext context)
            : base(context)
        {

        }
    }
}
