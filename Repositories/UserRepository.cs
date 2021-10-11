using AnthillCommon.Contracts;
using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Repositories
{
    public class UserRepository : ITEntityRepository<User>
    {
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll(User entity)
        {
            throw new NotImplementedException();
        }

        public User GetByKey(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetMany(User entity, System.Linq.Expressions.Expression<Func<User, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetSingle(User entity, System.Linq.Expressions.Expression<Func<User, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public bool IsAttached(User entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entityCurrent, User entityFrom)
        {
            throw new NotImplementedException();
        }
    }
}
