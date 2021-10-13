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
    public class UserService : AbstractService<User, UserDto>, IUserService
    {
        public UserService(IUnityContainer container)
           : base(container) { }
       
        private readonly UserRepository Repo = new UserRepository(new CommonContext());
        public async Task AddUser(UserDto user)
        {
            var userOriginal = CurrentMapper.Map<User>(user);
            await Repo.Add(userOriginal);
        }

        public async Task DeleteUser(UserDto user)
        {
            var userOriginal = CurrentMapper.Map<User>(user);
            await Repo.Remove(userOriginal);
        }


        public async Task<UserDto> GetUser(int id)
        {

            return await Task.Run(() => CurrentMapper.Map<UserDto>(Repo.GetByKey(id)));
        }

        public async Task UpdateUser(UserDto user)
        {
            var existingUser = Repo.GetByKey(user.Id);
            await Repo.Update(existingUser.Result, CurrentMapper.Map<User>(user));
        }
    }
}
