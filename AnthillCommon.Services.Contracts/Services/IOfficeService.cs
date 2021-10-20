using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface IOfficeService
    {
        Task<OfficeDto> GetOffice(int id);
        Task AddOffice(OfficeDto office);
        Task UpdateOffice(OfficeDto office);
        Task DeleteOffice(OfficeDto office);
    }
}
