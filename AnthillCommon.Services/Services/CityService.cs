using AnthilCommon.Common.Services;
using AnthillCommon.Contracts;
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

        private readonly IUnityContainer _container;
        public CityService(IUnityContainer container, IMapper autoMapper) : base(container, autoMapper) 
        {
            
            _container = container;
           
        }

        public async Task Add(CityDto city)
        {
            var _repo = _container.Resolve<ICityRepository>();
            var cityOriginal = AutoMapper.Map<City>(city);
            await _repo.Add(cityOriginal);
            
        }

        public async Task Delete(int id)
        {
            var _repo = _container.Resolve<ICityRepository>();
            await _repo.Remove(await _repo.GetByKey(id));
        }


        public async Task<CityDto> Get(int id)
        {
            var _repo = _container.Resolve<ICityRepository>();
            var data = await _repo.GetByKey(id);
            var result = AutoMapper.Map<CityDto>(data);
            return result;
        }

        public async Task Update(CityDto city)
        {
            var _repo = _container.Resolve<ICityRepository>();
            var existingCity = await _repo.GetByKey(city.Id);
            var updatedCity = AutoMapper.Map<City>(city);
            await _repo.Update(existingCity, updatedCity);
        }

    }
}
