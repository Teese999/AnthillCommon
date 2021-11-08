using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Mappers
{
    public class SubscriptionVersionMapperProfile : Profile
    {
        public SubscriptionVersionMapperProfile()
        {
            CreateMap<SubscriptionVersion, SubscriptionVersionDto>();
            CreateMap<SubscriptionVersionDto, SubscriptionVersion>()
                .ForMember(x => x.Id, y => y.Ignore());
        }
    }
}
