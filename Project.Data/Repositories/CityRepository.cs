using AnthillCommon.Contracts;
using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace AnthillCommon.Repositories
{
    public class CityRepository : IEntityRepository<City>
    {
        public async Task Add(City entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<City>> GetAll(City entity)
        {
            throw new NotImplementedException();
        }

        public Task<City> GetByKey(int key)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<City>> GetMany(City entity, Expression<Func<City, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Task<City> GetSingle(Expression<Func<City, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsAttached(City entity)
        {
            throw new NotImplementedException();
        }

        public Task Remove(City entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(City entityCurrent, City entityFrom)
        {
            throw new NotImplementedException();
        }
    }
}
