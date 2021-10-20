using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Mappers;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Mappers;
using AutoMapper;

namespace AnthillCommon.Services.Mappers
{
    public class OrganisationMapper : IOrganisationMapper
    {
        private MapperConfiguration configuration;
        private MapperConfiguration configurationReverse;
        public Mapper Mapper { get; set; }
        public Mapper MapperReverse { get; set; }
        public OrganisationMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Organisation, OrganisationDto>();
                cfg.CreateMap<OrganisationDto, Organisation>().ForMember(x => x.Id, y => y.Ignore());
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);

            configurationReverse = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrganisationDto, Organisation>();
            });
            configurationReverse.AssertConfigurationIsValid();
            MapperReverse = new Mapper(configurationReverse);
        }
    }
}
