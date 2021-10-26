using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface IUserService
    {
        Task<UserDto> Get(int id);
        Task Add(UserDto user);
        Task Update(UserDto user);
        Task Delete(int id);
        
    }
}
