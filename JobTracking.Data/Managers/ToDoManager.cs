using JobTracking.Core.Entities;
using JobTracking.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobTracking.Data.Managers
{
   public class ToDoManager : BaseManager<ToDo, ToDoRepository, MainDbContext>
    {
        public ToDoManager(ToDoRepository repository)
    : base(repository)
        {

        }
        public override async Task<ToDo> Update(ToDo entity)
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
        public override async Task<ToDo> Insert(ToDo entity)
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
