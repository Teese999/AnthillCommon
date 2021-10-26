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
    public class UserService : AbstractService, IUserService
    {
        private readonly UserRepository _repo = new UserRepository(new CommonContext());

        public UserService(IUnityContainer container, IMapper autoMapper) : base(container, autoMapper) { }
        public async Task Add(UserDto user)
        {
            var addeduser = AutoMapper.Map<User>(user);
            await _repo.Add(addeduser);
        }

        public async Task Delete(int id)
        {
            await _repo.Remove(await _repo.GetByKey(id));
        }


        public async Task<UserDto> Get(int id)
        {
            var data = await _repo.GetByKey(id);
            var result = AutoMapper.Map<UserDto>(data);
            return result;
        }

        public async Task Update(UserDto user)
        {
            var existingUser = await _repo.GetByKey(user.Id);
            var updatedUser = AutoMapper.Map<User>(user);

            await _repo.Update(existingUser, updatedUser);
        }
    }
}
