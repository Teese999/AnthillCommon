using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Mappers;
using AutoMapper;

namespace AnthillCommon.Services.Mappers
{
    public class CityMapperProfile : Profile
    {
        public CityMapperProfile()
        {
            CreateMap<City, CityDto>();
            CreateMap<CityDto, City>()
                .ForMember(x => x.Id, y => y.Ignore());
        }
    }
}

