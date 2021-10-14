using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;

namespace AnthillCommon.Mappings
{
    public class UserModelMapper
    {
        private MapperConfiguration configuration;
        public Mapper Mapper;
        public UserModelMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserModel, UserDto>();
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);
        }
    }
}
