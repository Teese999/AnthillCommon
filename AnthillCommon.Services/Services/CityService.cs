using AnthilCommon.Common.Services;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Repositories;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using System.Threading.Tasks;
using Unity;


namespace AnthillCommon.Services.Services
{
    public class CityService : AbstractService<City, CityDto>, ICityService
    {
        public CityService(IUnityContainer container)
            : base(container) { }

        private readonly CityRepository Repo = new CityRepository(new CommonContext());
        public async Task AddCity(CityDto City)
        {
            var CityOriginal = CurrentMapper.Map<City>(City);
            await Repo.Add(CityOriginal);
        }

        public async Task DeleteCity(CityDto City)
        {
            var CityOriginal = CurrentMapper.Map<City>(City);
            await Repo.Remove(CityOriginal);
        }


        public async Task<CityDto> GetCity(int id)
        {

            return await Task.Run(() => CurrentMapper.Map<CityDto>(Repo.GetByKey(id)));
        }

        public async Task UpdateCity(CityDto City)
        {
            var existingCity = Repo.GetByKey(City.Id);
            await Repo.Update(existingCity.Result, CurrentMapper.Map<City>(City));
        }
    }
}
