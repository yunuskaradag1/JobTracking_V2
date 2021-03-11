using JobTracking.Core.Entities;
using JobTracking.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobTracking.Data.Managers
{
   public class WorkTypeDefinitionManager : BaseManager<WorkTypeDefinition, WorkTypeDefinitionRepository, MainDbContext>
    {
        public WorkTypeDefinitionManager(WorkTypeDefinitionRepository repository)
    : base(repository)
        {

        }
        public override async Task<WorkTypeDefinition> Update(WorkTypeDefinition entity)
        {
            using (var transaction = repository.Context.Database.BeginTransaction())
            {
                try
                {
                    await base.Update(entity);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            return entity;
        }
        public override async Task<WorkTypeDefinition> Insert(WorkTypeDefinition entity)
        {
            using (var transaction = repository.Context.Database.BeginTransaction())
            {
                try
                {
                    await base.Insert(entity);
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
            }
            return entity;
        }
    }
}
