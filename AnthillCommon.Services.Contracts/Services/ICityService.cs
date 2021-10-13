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
        Task<CityDto> GetCity(int id);
        Task AddCity(CityDto city);
        Task UpdateCity(CityDto city);
        Task DeleteCity(CityDto city);
    }
}
