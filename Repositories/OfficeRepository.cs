using AnthillCommon.Contracts;
using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnthillCommon.Repositories
{
    public class OfficeRepository : ITEntityRepository<Office>
    {
        public void Add(Office entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Office> GetAll(Office entity)
        {
            throw new NotImplementedException();
        }

        public Office GetByKey(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Office> GetMany(Office entity, Expression<Func<Office, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Office> GetSingle(Office entity, Expression<Func<Office, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public bool IsAttached(Office entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Office entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Office entityCurrent, Office entityFrom)
        {
            throw new NotImplementedException();
        }
    }
}
