using AnthillCommon.Models;
using AnthillCommon.DataContext;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Data.SqlClient;

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
            IQueryable<TEntity> query = Context.Set<TEntity>();
            return await GetQuery(x => x.Id == key).FirstOrDefaultAsync();
        }
        public async Task<IEnumerable<TEntity>> GetAll()
        {

            Context.Set<TEntity>().ToArray();
            return await Context.Set<TEntity>().ToArrayAsync();
        }

        public async Task Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentException($"{typeof(TEntity)} - is Null");
            };
            await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Remove(TEntity entity)
        {
            var qq = entity;
            Context.Set<TEntity>().Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Update(TEntity entityCurrent, TEntity entityFrom)
        {
            await Task.Run(() => Context.Entry(entityCurrent).CurrentValues.SetValues(entityFrom));
            await Context.SaveChangesAsync();
        }

        public Task<bool> IsAttached(TEntity entity)
        {
            return Task.FromResult(Context.Set<TEntity>().Local.Any(e => e == entity));
        }

        public Task<TEntity> GetSingle(Expression<Func<TEntity, bool>> criteria)
        {
            return GetQuery().SingleOrDefaultAsync(criteria);
        }
        public async Task<IEnumerable<TEntity>> GetMany(Expression<Func<TEntity, bool>> criteria)
        {
            return await GetQuery(criteria).ToListAsync();
        }
        public async Task<IEnumerable<TEntity>> GetRange(int firstIndex, int countPerPage, Expression<Func<TEntity, bool>> criteria = null)
        {
            if (criteria == null)
            {
                
                return await Context.Set<TEntity>().Skip(firstIndex).Take(countPerPage).ToListAsync();
            }
            else
            {
                return await Context.Set<TEntity>().Where(criteria).Skip(firstIndex).Take(countPerPage).ToListAsync();
            }
            
        }
        public async Task<int> GetEntitiesCount()
        {
            
            return await Context.Set<TEntity>().CountAsync();
        }
        public async Task<int> GetEntitiesCount(Expression<Func<TEntity, bool>> criteria)
        {
            
            return await GetQuery(criteria).CountAsync();
        }
    }
}
