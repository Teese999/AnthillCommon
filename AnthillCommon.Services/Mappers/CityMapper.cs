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
    public class CityMapper : ICityMapper
    {
        //osipenkom: неправильный нейминг, по конвенции _blabla
        private MapperConfiguration configuration;
        private MapperConfiguration configurationReverse;
        //osipenkom: два маппера с двумя конфигурациями здесь не нужны. всё конфигурируется один раз
        public Mapper Mapper { get; set; }
        public Mapper MapperReverse { get; set; }
        public CityMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<City, CityDto>();
                cfg.CreateMap<CityDto, City>().ForMember(x => x.Id, y => y.Ignore());
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);


            configurationReverse = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CityDto, City>();
            });
            configurationReverse.AssertConfigurationIsValid();
            MapperReverse = new Mapper(configurationReverse);
        }
    }
}
