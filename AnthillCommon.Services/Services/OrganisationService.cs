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
    class OrganisationService : AbstractService<Organisation, OrganisationDto>, IOrganisationService
    {
        //osipenkom: все те же комментарии, что и в CityService
        //osipenkom: опечатка в слове Organization, нужно проверить по всему коду
        public OrganisationService(IUnityContainer container)
           : base(container) 
        {
            Mapper = OrganisationMapper.Mapper;
            MapperReverse = OrganisationMapper.MapperReverse;
        }
        private readonly OrganisationMapper OrganisationMapper = new OrganisationMapper();
        private readonly Mapper Mapper;
        private readonly Mapper MapperReverse;
        private readonly OrganisationRepository Repo = new OrganisationRepository(new CommonContext());
        public async Task AddOrganisation(OrganisationDto Organisation)
        {
            var OrganisationOriginal = Mapper.Map<Organisation>(Organisation);
            await Repo.Add(OrganisationOriginal);
        }

        public async Task DeleteOrganisation(OrganisationDto Organisation)
        {
            var OrganisationOriginal = MapperReverse.Map<Organisation>(Organisation);
            await Repo.Remove(OrganisationOriginal);
        }


        public async Task<OrganisationDto> GetOrganisation(int id)
        {

            return await Task.Run(() => CurrentMapper.Map<OrganisationDto>(Repo.GetByKey(id).Result));
        }

        public async Task UpdateOrganisation(OrganisationDto Organisation)
        {
            var existingOrganisation = Repo.GetByKey(Organisation.Id).Result;
            var updatedOrganisation = MapperReverse.Map<Organisation>(Organisation);
            await Repo.Update(existingOrganisation, updatedOrganisation);
        }
    }
}
