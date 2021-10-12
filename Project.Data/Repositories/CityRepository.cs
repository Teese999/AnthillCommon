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
    public class CityRepository : AbstractRepository<City>, ICityRepository
    {
        public CityRepository(CommonContext context) : base(context)
        {
        }
    }
}
