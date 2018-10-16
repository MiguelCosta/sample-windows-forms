namespace Mpc.WinFormsIoC.Application.Services.Users
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class UserService : IUserService
    {
        private static readonly Dictionary<string, string> _users = new Dictionary<string, string>();

        public Task CreateAsync(string username, string name)
        {
            _users.Add(username, name);
            return Task.CompletedTask;
        }

        public Task<string> GetNameAsync(string username)
        {
            string name = _users[username];
            return Task.FromResult(name);
        }
    }
}
