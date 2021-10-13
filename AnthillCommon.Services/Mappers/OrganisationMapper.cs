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
        public Mapper Mapper;
        public OrganisationMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Organisation, OrganisationDto>();
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);
        }
    }
}
