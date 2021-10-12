using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace AnthillCommon.Repositories
{
    public class UserRepository : AbstractRepository<User>, IUserRepository
    {
        public UserRepository(CommonContext context) : base(context)
        {   
        }
    }
}
