using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnthillCommon.Contracts
{
    interface ITEntityRepository<TEntity> where TEntity : IEntity
    {
        public IEnumerable<TEntity> GetAll(TEntity entity);
        public TEntity GetByKey(int key);
        public void Add(TEntity entity);
        public void Remove(TEntity entity);
        public void Update(TEntity entityCurrent, TEntity entityFrom);
        public bool IsAttached(TEntity entity);
        public IEnumerable<TEntity> GetSingle(TEntity entity, Expression<Func<TEntity, bool>> criteria);
        public IEnumerable<TEntity> GetMany(TEntity entity, Expression<Func<TEntity, bool>> criteria);

    }
}
