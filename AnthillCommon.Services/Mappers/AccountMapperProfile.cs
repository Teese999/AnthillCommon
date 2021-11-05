using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnthillCommon.Services.Mappers
{
    public class AccountMapperProfile : Profile
    {
        public AccountMapperProfile()
        {
            CreateMap<Account, AccountDto>();
            CreateMap<AccountDto, Account>()
                .ForMember(x => x.Password, y => y.Ignore())
                .ForMember(x => x.Login, y => y.Ignore())
                .ForMember(x => x.CreateDate, y => y.Ignore())
                .ForMember(x => x.UpdateTime, y => y.Ignore())
                .ForMember(x => x.IsPaid, y => y.Ignore())
                .ForMember(x => x.SubscriptionStartDate, y => y.Ignore());

        }
    }
}
