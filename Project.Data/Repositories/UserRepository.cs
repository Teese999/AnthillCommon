using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnthillCommon.Repositories
{
    public class UserRepository : AbstractRepository, IUserRepository
    {
        public UserRepository(CommonContext context) : base(context)
        {
            
        }
        public async Task Add(User entity) => await base.Add(entity);


        public async Task<IEnumerable<User>> GetAll(User entity) => await base.GetAll(entity);
       
        public async Task<IEnumerable<User>> GetMany(User entity, Expression<Func<User, bool>> criteria) => await base.GetMany(entity, criteria);

        public async Task<User> GetSingle(Expression<Func<User, bool>> criteria) => await base.GetSingle(criteria);

        public async Task<bool> IsAttached(User entity) => await base.IsAttached(entity);

        public async Task Remove(User entity) => await base.Remove(entity);
        public async Task Update(User entityCurrent, User entityFrom) => await base.Update(entityCurrent, entityFrom);

        Task<User> IEntityRepository<User>.GetByKey(int key) => base.GetByKey(key);
    }
}
