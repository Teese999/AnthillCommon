using AnthillCommon.Contracts;
using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace AnthillCommon.Repositories
{
    public class CityRepository : ITEntityRepository<City>
    {
        public void Add(City entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll(City entity)
        {
            throw new NotImplementedException();
        }

        public City GetByKey(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetMany(City entity, Expression<Func<City, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetSingle(City entity, Expression<Func<City, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public bool IsAttached(City entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(City entity)
        {
            throw new NotImplementedException();
        }

        public void Update(City entityCurrent, City entityFrom)
        {
            throw new NotImplementedException();
        }
    }
}
