using AnthilCommon.Common.Services;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Repositories;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AutoMapper;
using System.Threading.Tasks;
using Unity;


namespace AnthillCommon.Services.Services
{
    public class CityService : AbstractService, ICityService
    {
        private readonly CityRepository _repo = new CityRepository(new CommonContext());

        public CityService(IUnityContainer container, IMapper autoMapper) : base(container, autoMapper) { }

        public async Task Add(CityDto city)
        {
            var cityOriginal = AutoMapper.Map<City>(city);
            await _repo.Add(cityOriginal);
        }

        public async Task Delete(int id)
        {

            await _repo.Remove(await _repo.GetByKey(id));
        }


        public async Task<CityDto> Get(int id)
        {
            var data = await _repo.GetByKey(id);
            var result = AutoMapper.Map<CityDto>(data);
            return result;
        }

        public async Task Update(CityDto city)
        {
            
            var existingCity = await _repo.GetByKey(city.Id);
            var updatedCity = AutoMapper.Map<City>(city);
            await _repo.Update(existingCity, updatedCity);
        }

    }
}
