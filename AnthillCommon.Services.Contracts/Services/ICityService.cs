using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnthillCommon.Services.Contracts.Services
{
    //osipenkom: названия методов избыточны сами по себе. Например метод ICityService.Get, который возвращает CityDto сам по себе говорит, что это метод GetCity.
    //так что названия в таких случаях можно упрощать до Get/Add/Update/Delete. Итак понятно, что в итоге они выполняют операции над сущностью City
    public interface ICityService
    {
        Task<CityDto> GetCity(int id);
        Task AddCity(CityDto city);
        Task UpdateCity(CityDto city);
        Task DeleteCity(CityDto city);
    }
}
