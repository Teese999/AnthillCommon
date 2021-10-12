using System;
using System.Collections.Generic;
using System.Text;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Mappers;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Mappers;
using AutoMapper;
using IMapper = AutoMapper.IMapper;

namespace AnthillCommon.Services.Mappers
{
    public class OfficeMapper : AbstractMapper<Office, OfficeDto>, IOfficeMapper
    {
        protected override IMapper Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Office, OfficeDto>();

            });

            return config.CreateMapper();
        }
    }
}
