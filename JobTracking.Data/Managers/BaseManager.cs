using JobTracking.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JobTracking.Data.Managers
{
    public class BaseManager<TEntity, TRepository, TContext>
           where TEntity : BaseEntity
           where TRepository : BaseRepository<TEntity, TContext>
           where TContext : DbContext
    {
        public readonly TRepository repository;

        public BaseManager(TRepository repository)
        {
            this.repository = repository;
        }

        public virtual async Task<TEntity> Insert(TEntity entity)
        {
            var item = await repository.InsertAsync(entity);

            await repository.SaveChangesAsync();

            return item;
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            var item = await repository.UpdateAsync(entity);

            await repository.SaveChangesAsync();

            return item;
        }

        public virtual async System.Threading.Tasks.Task DeleteItem(TEntity entity)
        {
            await repository.DeleteItemAsync(entity);

            await repository.SaveChangesAsync();
        }
    }
}
