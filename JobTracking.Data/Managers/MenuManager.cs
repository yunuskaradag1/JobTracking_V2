using JobTracking.Core.Entities;
using JobTracking.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;



namespace JobTracking.Data.Managers
{
  public  class MenuManager : BaseManager<Menu, MenuRepository, MainDbContext>
    {
        public MenuManager(MenuRepository repository)
    : base(repository)
        {

        }
        public override async Task<Menu> Update(Menu entity)
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
        public override async Task<Menu> Insert(Menu entity)
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
