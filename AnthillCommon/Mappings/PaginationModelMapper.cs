using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnthillCommon.Mappings
{
    public class PaginationModelMapper : Profile
    {
        public PaginationModelMapper()
        {
            CreateMap<PaginationModel, PaginationModelDto>();
            CreateMap<PaginationModelDto, PaginationModel>();
        }
    }
}
