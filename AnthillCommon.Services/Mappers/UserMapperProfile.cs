using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Mappers;
using AutoMapper;
using AutoMapper.EntityFramework;
using AutoMapper.EntityFrameworkCore;
using AutoMapper.Collection;

namespace AnthillCommon.Services.Mappers
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>()
                .ForMember(x => x.Id, y => y.Ignore());
        }
    }
}
