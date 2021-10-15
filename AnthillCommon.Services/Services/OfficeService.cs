using AnthilCommon.Common.Services;
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
    public class OfficeService : AbstractService<Office, OfficeDto>, IOfficeService
    {
        public OfficeService(IUnityContainer container)
            : base(container) 
        {
            Mapper = OfficeMapper.Mapper;
            MapperReverse = OfficeMapper.MapperReverse;
        }
        private readonly OfficeMapper OfficeMapper = new OfficeMapper();
        private readonly Mapper Mapper;
        private readonly Mapper MapperReverse;
        private readonly OfficeRepository Repo = new OfficeRepository(new CommonContext());

        public async Task AddOffice(OfficeDto office)
        {
            var officeOriginal = Mapper.Map<Office>(office);
            await Repo.Add(officeOriginal);
        }

        public async Task DeleteOffice(OfficeDto office)
        {
            var officeOriginal = MapperReverse.Map<Office>(office);
            await Repo.Remove(officeOriginal);
        }


        public async Task<OfficeDto> GetOffice(int id)
        {
           
            return await Task.Run(() => CurrentMapper.Map<OfficeDto>(Repo.GetByKey(id).Result));
        }

        public async Task UpdateOffice(OfficeDto office)
        {
            var existingOffice = Repo.GetByKey(office.Id).Result;
            var updatedOffice = MapperReverse.Map<Office>(office);
            await Repo.Update(existingOffice, updatedOffice);
        }
    }
}
