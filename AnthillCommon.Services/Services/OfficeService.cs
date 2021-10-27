using AnthilCommon.Common.Services;
using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Repositories;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillCommon.Services.Mappers;
using AutoMapper;
using System.Diagnostics;
using System.Threading.Tasks;
using Unity;


namespace AnthillCommon.Services.Services
{
    public class OfficeService : AbstractService, IOfficeService
    {

        private readonly IUnityContainer _container;

        public OfficeService(IUnityContainer container, IMapper autoMapper) : base(container, autoMapper) 
        {
            _container = Container;
        }

        public async Task Add(OfficeDto office)
        {
            var _repo = _container.Resolve<IOfficeRepository>();
            var officeOriginal = AutoMapper.Map<Office>(office);
            await _repo.Add(officeOriginal);
        }

        public async Task Delete(int id)
        {
            var _repo = _container.Resolve<IOfficeRepository>();
            await _repo.Remove(await _repo.GetByKey(id));
        }


        public async Task<OfficeDto> Get(int id)
        {
            var _repo = _container.Resolve<IOfficeRepository>();
            var data = await _repo.GetByKey(id);
            var result = AutoMapper.Map<OfficeDto>(data);
            return result;
        }

        public async Task Update(OfficeDto office)
        {
            var _repo = _container.Resolve<IOfficeRepository>();
            var existingOffice = await _repo.GetByKey(office.Id);
            var updatedOffice = AutoMapper.Map<Office>(office);
            await _repo.Update(existingOffice, updatedOffice);
        }
    }
}
