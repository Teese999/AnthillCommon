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
        Task<UserDto> GetUser(int id);
        Task AddUser(UserDto user);
        Task UpdateUser(UserDto user);
        Task DeleteUser(UserDto user);
        
    }
}
