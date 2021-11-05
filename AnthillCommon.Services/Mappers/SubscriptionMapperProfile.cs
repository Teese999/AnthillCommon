using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Mappers
{
    public class SubscriptionMapperProfile : Profile
    {
        public SubscriptionMapperProfile()
        {
            CreateMap<Subscription, SubscriptionDto>();
            CreateMap<SubscriptionDto, Subscription>()
                .ForMember(x => x.Id, y => y.Ignore());
        }
    }
}
