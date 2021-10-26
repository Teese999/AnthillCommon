using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;

namespace AnthillCommon.Mappings
{
    public class CityModelMapper : Profile
    {
        public CityModelMapper()
        {
            CreateMap<CityModel, CityDto>();
        }
    }
}
