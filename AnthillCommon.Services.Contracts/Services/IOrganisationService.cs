using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    //osipenkom: те же комментарии, что и для ICityService
    public interface IOrganisationService
    {
        Task<OrganisationDto> GetOrganisation(int id);
        Task AddOrganisation(OrganisationDto organisation);
        Task UpdateOrganisation (OrganisationDto organisation);
        Task DeleteOrganisation(OrganisationDto organisation);
    }
}
