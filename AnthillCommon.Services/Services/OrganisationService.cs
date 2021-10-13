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
    class OrganisationService : AbstractService<Organisation, OrganisationDto>, IOrganisationService
    {
        public OrganisationService(IUnityContainer container)
           : base(container) { }

        private readonly OrganisationRepository Repo = new OrganisationRepository(new CommonContext());
        public async Task AddOrganisation(OrganisationDto Organisation)
        {
            var OrganisationOriginal = CurrentMapper.Map<Organisation>(Organisation);
            await Repo.Add(OrganisationOriginal);
        }

        public async Task DeleteOrganisation(OrganisationDto Organisation)
        {
            var OrganisationOriginal = CurrentMapper.Map<Organisation>(Organisation);
            await Repo.Remove(OrganisationOriginal);
        }


        public async Task<OrganisationDto> GetOrganisation(int id)
        {

            return await Task.Run(() => CurrentMapper.Map<OrganisationDto>(Repo.GetByKey(id)));
        }

        public async Task UpdateOrganisation(OrganisationDto Organisation)
        {
            var existingOrganisation = Repo.GetByKey(Organisation.Id);
            await Repo.Update(existingOrganisation.Result, CurrentMapper.Map<Organisation>(Organisation));
        }
    }
}
