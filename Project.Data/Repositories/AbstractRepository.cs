using AnthillCommon.Models;
using AnthillCommon.DataContext;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace AnthillCommon.Repositories
{
    public abstract class AbstractRepository<TEntity> 
        where TEntity : class, IEntity 
    {
        protected AbstractRepository(CommonContext context)
        {
            Context = context;
        }
        protected CommonContext Context { get; private set; }

        protected IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> criteria = null)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();

            if (criteria != null)
            {
                query = query.Where(criteria);
            }

            return query;
        }

        public async Task<TEntity> GetByKey(int key)
        {
            if (key < 0)
            {
                throw new ArgumentException($"Key {key} is missing");
            };

            return await GetQuery(x => x.Id == key).FirstOrDefaultAsync();
        }

        public async Task Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentException($"{typeof(TEntity)} - is Null");
            };
            await Context.Set<TEntity>().AddAsync(entity);
        }

        public async Task Remove(TEntity entity)
        {
            await Task.Run(() => Context.Set<TEntity>().Remove(entity));
        }

        public async Task Update(TEntity entityCurrent, TEntity entityFrom)
        {
            await Task.Run(() => Context.Entry(entityCurrent).CurrentValues.SetValues(entityFrom));
        }

        public Task<bool> IsAttached(TEntity entity)
        {
            return Task.FromResult(Context.Set<TEntity>().Local.Any(e => e == entity));
        }

        public Task<TEntity> GetSingle(Expression<Func<TEntity, bool>> criteria)
        {
            return GetQuery().SingleOrDefaultAsync(criteria);
        }

        public async Task<IEnumerable<TEntity>> GetMany(TEntity entity, Expression<Func<TEntity, bool>> criteria)
        {
            return await GetQuery(criteria).ToListAsync();
        }

    }
}
