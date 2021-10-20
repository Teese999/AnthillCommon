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
        private MapperConfiguration configurationReverse;
        public Mapper Mapper { get; set; }
        public Mapper MapperReverse { get; set; }
        public OfficeMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Office, OfficeDto>();
                cfg.CreateMap<OfficeDto, Office>().ForMember(x => x.Id, y => y.Ignore());
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);

            configurationReverse = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OfficeDto, Office>();
            });
            configurationReverse.AssertConfigurationIsValid();
            MapperReverse = new Mapper(configurationReverse);
        }

    }
}
