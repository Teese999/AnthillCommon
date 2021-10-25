using AnthillCommon.Common.Contracts;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper.Configuration;

namespace AnthillCommon.Services.Contracts.Mappers
{
    //osipenkom: те же комментарии, что и для ICityMapper
    public interface IUserMapper : IMapper<User, UserDto>
    {
    }
}