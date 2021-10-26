using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    public interface ICityService
    {
        Task<CityDto> Get(int id);
        Task Add(CityDto city);
        Task Update(CityDto city);
        Task Delete(int id);
    }
}
