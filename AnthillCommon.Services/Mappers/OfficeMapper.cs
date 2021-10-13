using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Mappers;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Mappers;
using AutoMapper;
using IMapper = AutoMapper.IMapper;

namespace AnthillCommon.Services.Mappers
{
    public class OfficeMapper : IOfficeMapper
    {
        private MapperConfiguration configuration;
        public Mapper Mapper;
        public OfficeMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Office, OfficeDto>();
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);
        }
    }
}
