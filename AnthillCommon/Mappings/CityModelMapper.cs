using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;

namespace AnthillCommon.Mappings
{
    public class CityModelMapper
    {
        private MapperConfiguration configuration;
        public Mapper Mapper;
        public CityModelMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<City, CityDto>();
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);
        }
    }
}
