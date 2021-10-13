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
        public Mapper Mapper;
        public UserMapper()
        {
            configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDto>();
            });
            configuration.AssertConfigurationIsValid();
            Mapper = new Mapper(configuration);
        }
    }
}
