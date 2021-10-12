using AnthillCommon.Contracts;
using AnthillCommon.DataContext;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace AnthillCommon.Repositories
{
    public abstract class AbstractRepository : IRepository, IEntityRepository<IEntity>
    {
        protected AbstractRepository(CommonContext context)
        {
            Context = context;
        }
        protected CommonContext Context { get; private set; }

        protected IQueryable<IEntity> GetQuery<IEntity>(Expression<Func<IEntity, bool>> criteria = null)
            where IEntity : class
        {
            IQueryable<IEntity> query = Context.Set<IEntity>();

            if (criteria != null)
            {
                query = query.Where(criteria);
            }
            
            return query;
        }
       
        

        public async Task<IEnumerable<IEntity>> GetAll(IEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentException($"{typeof(IEntity)} - is Null");
            };

            return await Context.Set<IEntity>().ToArrayAsync();
        }

        public async Task<IEntity> GetByKey(int key)
        {
            if (key < 0)
            {
                throw new ArgumentException($"Key {key} is missing");
            };

            return await GetQuery<IEntity>(x => x.Id == key).FirstOrDefaultAsync();
        }

        public async Task Add(IEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentException($"{typeof(IEntity)} - is Null");
            };
            await Context.Set<IEntity>().AddAsync(entity);        
        }

        public async Task Remove(IEntity entity)
        {
            await Task.Run(() => Context.Set<IEntity>().Remove(entity)); 
        }

        public async Task Update(IEntity entityCurrent, IEntity entityFrom)            
        {
            await Task.Run(() => Context.Entry(entityCurrent).CurrentValues.SetValues(entityFrom));                    
        }

        public Task<bool> IsAttached(IEntity entity)
        {
           return Task.FromResult(Context.Set<IEntity>().Local.Any(e => e == entity));
        }

        public Task<IEntity> GetSingle(Expression<Func<IEntity, bool>> criteria)
        {
            return  GetQuery<IEntity>().SingleOrDefaultAsync(criteria);
        }

        public async Task<IEnumerable<IEntity>> GetMany(IEntity entity, Expression<Func<IEntity, bool>> criteria)
        {
            return await GetQuery<IEntity>(criteria).ToListAsync();
        }

    }
}
