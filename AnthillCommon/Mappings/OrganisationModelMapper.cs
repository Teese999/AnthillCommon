using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;

namespace AnthillCommon.Mappings
{
    public class OrganisationModelMapper
    {
        private MapperConfiguration configuration;
        public Mapper Mapper;
        public OrganisationModelMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrganisationModel, OrganisationDto>();
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);
        }
    }
}
