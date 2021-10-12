using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AnthillCommon.Models;

namespace AnthillCommon.Contracts
{
    public interface IUserRepository : IEntityRepository<User>
    {

    }
}
