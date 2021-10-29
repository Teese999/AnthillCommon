using AnthilCommon.Common.Services;
using AnthillCommon.Contracts;
using AnthillCommon.DataContext;
using AnthillCommon.Models;
using AnthillCommon.Repositories;
using AnthillCommon.Services.Contracts.Models;
using AnthillCommon.Services.Contracts.Services;
using AnthillCommon.Services.Mappers;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Unity;

namespace AnthillCommon.Services.Services
{
    public class UserService : AbstractService, IUserService
    {
        private readonly IUnityContainer _container;

        public UserService(IUnityContainer container, IMapper autoMapper) : base(container, autoMapper)
        {
            _container = container;
        }
        public async Task Add(UserDto user)
        {
            var _repo = _container.Resolve<IUserRepository>();
            var addeduser = AutoMapper.Map<User>(user);
            await _repo.Add(addeduser);
        }

        public async Task Delete(int id)
        {
            var _repo = _container.Resolve<IUserRepository>();
            await _repo.Remove(await _repo.GetByKey(id));
        }


        public async Task<UserDto> Get(int id)
        {
            var _repo = _container.Resolve<IUserRepository>();
            var data = await _repo.GetByKey(id);
            var result = AutoMapper.Map<UserDto>(data);
            return result;
        }
        public async Task<PaginationModelDto> GetPage(PaginationSettingsDto settingsDto)
        {
            if (settingsDto.CountPerPage == 0) { settingsDto.CountPerPage = 10; }


            var _repoUser = _container.Resolve<IUserRepository>();

            var data = new List<User>();

            var firstUserIndex = settingsDto.CountPerPage * (settingsDto.PageNumber);

            var pagesCount = 0;
            var usersCount = 0;

            Expression<Func<User, bool>> criteria = null;


            if (settingsDto.SelectedCity != null)
            {
                var _repoOffice = _container.Resolve<IOfficeRepository>();
                var officesInSelectedCity = await _repoOffice.GetMany(x => x.City.Id == settingsDto.SelectedCity);

                criteria = (x => officesInSelectedCity
                    .Select(x => x.Id).ToList()
                        .Any(z => z == x.OfficeId));
            }
            if (settingsDto.SelectedOffice!= null)
            {
                criteria = (x => x.OfficeId == settingsDto.SelectedOffice);
            }

            data = (await _repoUser.GetRange(firstUserIndex, settingsDto.CountPerPage, criteria)).ToList();
            pagesCount = await _repoUser.GetEntitiesCount(criteria) / settingsDto.CountPerPage;
            usersCount = await _repoUser.GetEntitiesCount(criteria);


            return new PaginationModelDto()
            {
                Users = data,
                PagesCount = pagesCount,
                UsersCount = usersCount,

            };
        }

        public async Task Update(UserDto user)
        {
            var _repo = _container.Resolve<IUserRepository>();
            var existingUser = await _repo.GetByKey(user.Id);
            var updatedUser = AutoMapper.Map<User>(user);

            await _repo.Update(existingUser, updatedUser);
        }
    }
}
