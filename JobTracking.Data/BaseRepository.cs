using JobTracking.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JobTracking.Data
{
    public abstract class BaseRepository<T, TContext> : IRepository<T> where T : BaseEntity
        where TContext : DbContext
    {
        public TContext Context { get; private set; }

        public BaseRepository(TContext context)
        {
            Context = context;
        }

        public async System.Threading.Tasks.Task DeleteByIdAsync(int id)
        {
            var set = Context.Set<T>();

            var item = await set.FirstOrDefaultAsync(t => t.Id == id);

            await DeleteItemAsync(item);
        }

        public async System.Threading.Tasks.Task DeleteItemAsync(T item)
        {
            await System.Threading.Tasks.Task.Run(() =>
            {
                var set = Context.Set<T>();

                set.Remove(item);
            });
        }

        public IQueryable<T> Filter(Expression<Func<T, bool>> expression)
        {
            var set = Context.Set<T>();

            return set.Where(expression);
        }

        public async Task<List<T>> GetAllItemsAsync()
        {
            var set = Context.Set<T>();

            return await set.ToListAsync();
        }

        public async Task<T> GetItemAsync(Expression<Func<T, bool>> expression)
        {
            return await Filter(expression).FirstOrDefaultAsync();
        }

        public async Task<List<T>> GetItemsAsync(Expression<Func<T, bool>> expression)
        {
            return await Filter(expression).ToListAsync();
        }

        public async Task<int> GetCount(Expression<Func<T, bool>> expression)
        {
            return await Filter(expression).CountAsync();
        }

        public async Task<T> InsertAsync(T item)
        {
            var set = Context.Set<T>();

            var entity = await set.AddAsync(item);

            return entity.Entity;
        }

        public async System.Threading.Tasks.Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(T item)
        {
            return await System.Threading.Tasks.Task.Run(() =>
            {
                var set = Context.Set<T>();

                var entity = set.Update(item);

                return entity.Entity;
            });
        }

        public IQueryable<T> GetQuery()
        {
            return Context.Set<T>().AsQueryable();
        }
    }
}
