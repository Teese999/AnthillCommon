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
        Task<OfficeDto> Get(int id);
        Task Add(OfficeDto office);
        Task Update(OfficeDto office);
        Task Delete(int id);
    }
}
