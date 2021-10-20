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
    public class UserService : AbstractService<User, UserDto>, IUserService
    {
        public UserService(IUnityContainer container)
           : base(container) 
        {
            Mapper = UserMapper.Mapper;
            MapperReverse = UserMapper.MapperReverse;
        }


        private readonly UserMapper UserMapper = new UserMapper();
        private readonly Mapper Mapper;
        private readonly Mapper MapperReverse;
        private readonly UserRepository Repo = new UserRepository(new CommonContext());
        public async Task AddUser(UserDto user)
        {
            var addeduser = Mapper.Map<User>(user);
            await Repo.Add(addeduser);
        }

        public async Task DeleteUser(UserDto user)
        {
            var userOriginal = MapperReverse.Map<User>(user);

            await Repo.Remove(userOriginal);
        }


        public async Task<UserDto> GetUser(int id)
        {

            return await Task.Run(() => CurrentMapper.Map<UserDto>(Repo.GetByKey(id).Result));
        }

        public async Task UpdateUser(UserDto user)
        {
            var existingUser = Repo.GetByKey(user.Id).Result;
            var updatedUser = MapperReverse.Map<User>(user);

            await Repo.Update(existingUser, updatedUser);
        }
    }
}
