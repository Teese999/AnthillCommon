using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Mappings
{
    public class PaginationSettingsMapping : Profile
    {
        public PaginationSettingsMapping()
        {
            CreateMap<PaginationSettingsModel, PaginationSettingsDto>();
            CreateMap<PaginationSettingsDto, PaginationSettingsModel>();
        }
    }
}
