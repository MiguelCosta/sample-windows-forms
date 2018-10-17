namespace Mpc.WinFormsIoC.Application.Services.Users
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;
    using Mpc.WinFormsIoC.Domain.Core;
    using Mpc.WinFormsIoC.Domain.Models;

    public class UserService : IUserService
    {
        private static readonly List<UserDto> _users = new List<UserDto>();
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task CreateAsync(UserDto user)
        {
            var model = new UserModel
            {
                Email = user.Email,
                Name = user.Name,
                Password = user.Password,
                Username = user.Username
            };

            _unitOfWork.UsersRepository.Insert(model);

            return _unitOfWork.SaveChangesAsync();
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
