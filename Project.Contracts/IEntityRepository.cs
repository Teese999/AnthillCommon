using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnthillCommon.Contracts
{
    public interface IEntityRepository<IEntity>
    {
        public Task<IEntity> GetByKey(int key);
        public Task Add(IEntity entity);
        public Task Remove(IEntity entity);
        public Task Update(IEntity entityCurrent, IEntity entityFrom);
        public Task<bool> IsAttached(IEntity entity);
        public Task<IEntity> GetSingle(Expression<Func<IEntity, bool>> criteria);
        public Task<IEnumerable<IEntity>> GetMany(Expression<Func<IEntity, bool>> criteria);
        public Task<IEnumerable<IEntity>> GetAll();
        public Task<IEnumerable<IEntity>> GetRange(int firstIndex, int lastIndex, Expression<Func<IEntity, bool>> criteria = null);
        public Task<int> GetEntitiesCount(Expression<Func<IEntity, bool>> criteria = null);

    }
}
