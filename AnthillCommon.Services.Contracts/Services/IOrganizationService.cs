using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface IOrganizationService
    {
        Task<OrganizationDto> Get(int id);
        Task Add(OrganizationDto Organization);
        Task Update (OrganizationDto Organization);
        Task Delete(int id);
    }
}
