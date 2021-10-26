using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Mappers;
using AutoMapper;

namespace AnthillCommon.Services.Mappers
{
    public class OfficeMapperProfile : Profile
    {
        public OfficeMapperProfile()
        {
            CreateMap<Office, OfficeDto>();
            CreateMap<OfficeDto, Office>()
                .ForMember(x => x.Id, y => y.Ignore());
        }

    }
}
