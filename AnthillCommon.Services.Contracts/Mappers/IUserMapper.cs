using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;

namespace AnthillCommon.Services.Contracts.Mappers
{
    public  interface IUserMapper : IMapper<User, UserDto>
    {
    }
}