using AnthillCommon.Contracts;
using AnthillCommon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnthillCommon.Repositories
{
    public class OrganizationRepository : ITEntityRepository<Organization>
    {
        public void Add(Organization entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Organization> GetAll(Organization entity)
        {
            throw new NotImplementedException();
        }

        public Organization GetByKey(int key)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Organization> GetMany(Organization entity, Expression<Func<Organization, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Organization> GetSingle(Organization entity, Expression<Func<Organization, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public bool IsAttached(Organization entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Organization entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Organization entityCurrent, Organization entityFrom)
        {
            throw new NotImplementedException();
        }
    }
}
