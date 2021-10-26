using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;

namespace AnthillCommon.Mappings
{
    public class OfficeModelMapper : Profile
    {
        public OfficeModelMapper()
        {
            CreateMap<OfficeModel, OfficeDto>();
        }
    }
}
