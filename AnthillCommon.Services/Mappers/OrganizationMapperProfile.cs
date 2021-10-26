using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Mappers;
using AutoMapper;

namespace AnthillCommon.Services.Mappers
{
    public class OrganizationMapperProfile : Profile
    {
        public OrganizationMapperProfile()
        {
            CreateMap<Organization, OrganizationDto>();
            CreateMap<OrganizationDto, Organization>()
                .ForMember(x => x.Id, y => y.Ignore());
        }
    }
}
