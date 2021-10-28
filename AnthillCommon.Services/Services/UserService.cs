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
            var paginationModel = new PaginationModelDto();

            var _repoUser = _container.Resolve<IUserRepository>();

            var data = new List<User>();

            var firstUserIndex = settingsDto.CountPerPage * (settingsDto.PageNumber);
            var lastUserIndex = firstUserIndex * settingsDto.CountPerPage;

            if (lastUserIndex <= 0)
            {
                lastUserIndex = settingsDto.CountPerPage;
            }

            var prevPage = settingsDto.Clone();
            var nextPage = settingsDto.Clone();

            Expression<Func<User, bool>> criteria = null;
            if (!settingsDto.OrderByOffice && !settingsDto.OrderByCity)
            {
                data = _repoUser.GetRange(firstUserIndex, lastUserIndex).Result.ToList();
            }
            if (settingsDto.OrderByCity)
            {
                var _repoOffice = _container.Resolve<IOfficeRepository>();
                var officesInSelectedCity = await _repoOffice.GetMany(x => x.City.Id == settingsDto.SelctedCity);

                criteria = (x => officesInSelectedCity
                    .Select(x => x.Id).ToList()
                        .Any(z => z == x.OfficeId));

                data = _repoUser.GetRange(firstUserIndex, lastUserIndex, criteria).Result.ToList();

            }
            else if (settingsDto.OrderByOffice)
            {
                criteria = (x => x.OfficeId == settingsDto.SelectedOffice);

                data = _repoUser.GetRange(firstUserIndex, lastUserIndex, criteria).Result.ToList();
            }

            if (settingsDto.PageNumber > 1) { prevPage.PageNumber -= 1; }
            else { prevPage.PageNumber = 0; }

            if (((settingsDto.PageNumber+1) * settingsDto.CountPerPage) <= (data.Count))
            {
                nextPage.PageNumber +=1;
            }

            return new PaginationModelDto()
            {
                PrevPage = prevPage,
                NextPage = nextPage,
                Users = data,


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
