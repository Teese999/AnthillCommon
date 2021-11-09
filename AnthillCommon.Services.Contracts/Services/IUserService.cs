using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using Microsoft.AspNetCore.Mvc;
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
        Task<IActionResult> Add(UserDto user, int userId);
        Task Update(UserDto user);
        Task Delete(int id);
        Task<PaginationModelDto> GetPage(PaginationSettingsDto paginationSettings);


    }
}
