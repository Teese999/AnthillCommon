using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnthillCommon.Repositories
{
    public abstract class AbstractRepository : IRepository
    {
        protected AbstractRepository(CommonContext context)
        {
            Context = context;
        }
        protected CommonContext Context { get; private set; }

        protected IQueryable<TEntity> GetQuery<TEntity>(Expression<Func<TEntity, bool>> criteria = null)
            where TEntity : class
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();

            if (criteria != null)
            {
                query = query.Where(criteria);
            }

            return query;
        }
        /// <summary>
        /// Get single TEntity from database by PK
        /// </summary>
        protected TEntity GetByKey<TEntity>(params object[] keyValues)
            where TEntity : class
        {
            return Context.Set<TEntity>().Find(keyValues);
        }
        /// <summary>
        /// Get single TEntity from database by predicate
        /// </summary>
        protected TEntity GetSingle<TEntity>(Expression<Func<TEntity, bool>> criteria)
            where TEntity : class
        {
            return GetQuery<TEntity>().SingleOrDefault(criteria);
        }

        /// <summary>
        /// Add TEntity to database
        /// </summary>
        protected TEntity Add<TEntity>(TEntity entity)
            where TEntity : class
        {

            if (entity == null)
            {
                throw new ArgumentException($"{typeof(TEntity)} - is Null");
            }

            return Context.Set<TEntity>().Add(entity).Entity;
        }
        /// <summary>
        /// Changing fields of curent TEntity to new fields
        /// </summary>
        /// <param name="entity">Old params TEntity</param>
        /// <param name="fromEntity">New params TEntity</param>
        protected void Update<TEntity>(TEntity entity, TEntity fromEntity)
            where TEntity : class
        {
            if (entity == null)
            {
                throw new ArgumentException($"{typeof(TEntity)} - is Null");
            }

            Context.Entry(entity).CurrentValues.SetValues(fromEntity);
        }
        /// <summary>
        /// Check is database contains TEntity
        /// </summary>
        protected bool IsEntityAttached<TEntity>(TEntity entity)
            where TEntity : class
        {

            return Context.Set<TEntity>().Local.Any(e => e == entity);
        }
        /// <summary>
        /// Delete TEntity from database
        /// </summary>
        protected void Remove<TEntity>(TEntity entity)
            where TEntity : class
        {
            if (entity == null)
            {
                throw new ArgumentException($"{typeof(TEntity)} - is Null");
            }

            Context.Set<TEntity>().Remove(entity);
        }
    }
}
