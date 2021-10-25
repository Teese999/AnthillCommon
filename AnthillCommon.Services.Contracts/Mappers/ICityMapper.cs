using AnthillCommon.Common.Contracts;
using AnthillCommon.Models;
using AnthillCommon.Services.Contracts.Models;

namespace AnthillCommon.Services.Contracts.Mappers
{
    //osipenkom: не ясно, зачем тут используется интерфейс IMapper. Если его удалить то ничего не изменится
    public interface ICityMapper : IMapper<City, CityDto>
    {
    }
}
