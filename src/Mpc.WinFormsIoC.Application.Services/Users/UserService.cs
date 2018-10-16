namespace Mpc.WinFormsIoC.Application.Services.Users
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;

    public class UserService : IUserService
    {
        private static readonly List<UserDto> _users = new List<UserDto>();

        public Task CreateAsync(UserDto user)
        {
            _users.Add(user);
            return Task.CompletedTask;
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            await Task.Delay(3000).ConfigureAwait(false);
            return _users;
        }

        public Task<UserDto> GetByUsernameAsync(string username)
        {
            var user = _users.FirstOrDefault(x => x.Username == username);
            return Task.FromResult(user);
        }
    }
}
