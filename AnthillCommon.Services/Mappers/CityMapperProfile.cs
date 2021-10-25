using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Mappers
{
    //osipenkom: автомаппер конфигурируется один раз здесь
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
