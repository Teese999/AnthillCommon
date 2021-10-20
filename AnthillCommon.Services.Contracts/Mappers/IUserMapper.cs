using AnthillCommon.Common.Contracts;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper.Configuration;

namespace AnthillCommon.Services.Contracts.Mappers
{
    public  interface IUserMapper : IMapper<User, UserDto>
    {
    }
}