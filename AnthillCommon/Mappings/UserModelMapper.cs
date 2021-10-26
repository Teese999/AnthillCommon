using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;

namespace AnthillCommon.Mappings
{
    public class UserModelMapper : Profile
    {
        public UserModelMapper()
        {
            CreateMap<UserModel, UserDto>();
        }
    }
}
