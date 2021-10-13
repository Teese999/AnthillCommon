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
    public class OfficeService : AbstractService<Office, OfficeDto>, IOfficeService
    {
        public OfficeService(IUnityContainer container)
            : base(container) { }
        private readonly OfficeRepository Repo = new OfficeRepository(new CommonContext());

        public async Task AddOffice(OfficeDto office)
        {
            var officeOriginal = CurrentMapper.Map<Office>(office);
            await Repo.Add(officeOriginal);
        }

        public async Task DeleteOffice(OfficeDto office)
        {
            var officeOriginal = CurrentMapper.Map<Office>(office);
            await Repo.Remove(officeOriginal);
        }


        public async Task<OfficeDto> GetOffice(int id)
        {

            return await Task.Run(() => CurrentMapper.Map<OfficeDto>(Repo.GetByKey(id)));
        }

        public async Task UpdateOffice(OfficeDto office)
        {
            var existingOffice = Repo.GetByKey(office.Id);
            await Repo.Update(existingOffice.Result, CurrentMapper.Map<Office>(office));
        }
    }
}
