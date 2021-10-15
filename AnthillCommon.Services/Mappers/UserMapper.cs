using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Mappers;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Mappers;
using AutoMapper;
using AutoMapper.EntityFramework;
using AutoMapper.EntityFrameworkCore;
using AutoMapper.Collection;
using AnthillCommon.Common.Contracts;

namespace AnthillCommon.Services.Mappers
{
    public class UserMapper : IUserMapper
    {
        private MapperConfiguration configuration;
        private MapperConfiguration configurationReverse;
        public Mapper Mapper { get; set; }
        public Mapper MapperReverse { get; set; }
        public UserMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Id, y => y.Ignore()).ForMember(x => x.Office, y => y.Ignore());
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);

            configurationReverse = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<UserDto, User>().ForMember(x => x.Office, y => y.Ignore());
            });
            configurationReverse.AssertConfigurationIsValid();
            MapperReverse = new Mapper(configurationReverse);
        }
    }
}
