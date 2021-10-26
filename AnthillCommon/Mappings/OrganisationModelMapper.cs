using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using AutoMapper;

namespace AnthillCommon.Mappings
{
    public class OrganizationModelMapper : Profile
    {
        public OrganizationModelMapper()
        {
            CreateMap<OrganizationModel, OrganizationDto>();
        }
    }
}
