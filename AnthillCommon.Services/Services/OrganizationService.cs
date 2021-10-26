﻿using AnthilCommon.Common.Services;
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
    class OrganizationService : AbstractService, IOrganizationService
    {
        private readonly OrganizationRepository _repo = new OrganizationRepository(new CommonContext());

        public OrganizationService(IUnityContainer container, IMapper autoMapper) : base(container, autoMapper) { }

        public async Task Add(OrganizationDto organization)
        {
            var OrganizationOriginal = AutoMapper.Map<Organization>(organization);
            await _repo.Add(OrganizationOriginal);
        }

        public async Task Delete(int id)
        {
            await _repo.Remove(await _repo.GetByKey(id));
        }


        public async Task<OrganizationDto> Get(int id)
        {
            var data = await _repo.GetByKey(id);
            var result = AutoMapper.Map<OrganizationDto>(data);
            return result;
            
        }

        public async Task Update(OrganizationDto organization)
        {
            var existingOrganization = await _repo.GetByKey(organization.Id);
            var updatedOrganization = AutoMapper.Map<Organization>(organization);
            await _repo.Update(existingOrganization, updatedOrganization);

        }
    }
}
