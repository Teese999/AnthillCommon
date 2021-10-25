using AnthilCommon.Common.Services;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Repositories;
using AnthillCommon.Services.Contracts.Mappers;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillCommon.Services.Mappers;
using AutoMapper;
using System.Threading.Tasks;
using Unity;


namespace AnthillCommon.Services.Services
{
    public class CityService : AbstractService<City, CityDto>, ICityService
    {
        public CityService(IUnityContainer container, IMapper autoMapper)
            : base(container) 
        {
            //osipenkom: зачем тут два мапера? можно же один маппер настроить и в одну и в другую сторону
            Mapper = CityMapper.Mapper;
            MapperReverse = CityMapper.MapperReverse;
        }

        //osipenkom: приватные поля по именной конвенции именуются как _blabla
        //osipenkom: маппер инстанцирован в обход фабрики. зачем тогда вообще нужна фабрика?
        private readonly CityMapper CityMapper = new CityMapper();
        private readonly Mapper Mapper;
        private readonly Mapper MapperReverse;
        //osipenkom: репозиторий зарегестрирован в Unity, но инстанцируется явно. Это неправильно
        private readonly CityRepository Repo = new CityRepository(new CommonContext());
        
        //osipenkom: название переменных по конвенции именуется как blabla
        public async Task AddCity(CityDto City)
        {
            //osipenkom: название переменных по конвенции именуется как blabla
            var CityOriginal = Mapper.Map<City>(City);
            await Repo.Add(CityOriginal);
        }

        public async Task DeleteCity(CityDto City)
        {
            var CityOriginal = MapperReverse.Map<City>(City);
            await Repo.Remove(CityOriginal);
        }


        public async Task<CityDto> GetCity(int id)
        {
            //osipenkom: лишний Task.Run, зачем?
            //var data = await Repo.GetByKey(id);
            //var result = CurrentMapper.Map<CityDto>(data);
            //return result;
            return await Task.Run(() => CurrentMapper.Map<CityDto>(Repo.GetByKey(id).Result));
        }

        public async Task UpdateCity(CityDto City)
        {
            //osipenkom: .Result - неправильно
            //правильно - var existingCity = await Repo.GetByKey(City.Id);
            var existingCity = Repo.GetByKey(City.Id).Result;
            var updatedCity = MapperReverse.Map<City>(City);
            await Repo.Update(existingCity, updatedCity);
        }

        //osipenkom: посмотри этот пример использования автомаппера, в методе созданном для примера: не нужны ни абстрактные мапперы, ни фабрики.
        public async Task AddCityNew(CityDto City)
        {
            var cityOriginal = AutoMapper.Map<City>(City);
            await Repo.Add(cityOriginal);
        }
    }
}
