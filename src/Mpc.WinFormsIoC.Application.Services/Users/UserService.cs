namespace Mpc.WinFormsIoC.Application.Services.Users
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;
    using Mpc.WinFormsIoC.Application.Services.Mappings;
    using Mpc.WinFormsIoC.Application.Services.Security;
    using Mpc.WinFormsIoC.Domain.Core;
    using Mpc.WinFormsIoC.Domain.Models;
    using Polly;

    public class UserService : IUserService
    {
        private readonly IEncryptText _encryptText;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(
            IEncryptText encryptText,
            IUnitOfWork unitOfWork)
        {
            _encryptText = encryptText;
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(UserDto user)
        {
            var userModel = user.ToModel();
            userModel.Password = _encryptText.Encrypt(user.Password);

            await _unitOfWork.UsersRepository.InsertAsync(userModel).ConfigureAwait(false);

            await _unitOfWork.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            // example to use retry pattern
            // https://azure.microsoft.com/pt-pt/blog/using-the-retry-pattern-to-make-your-cloud-application-more-resilient/
            var policy = await Policy
                .Handle<Exception>()
                .WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(2))
                .ExecuteAndCaptureAsync(async () => await _unitOfWork.UsersRepository.GetByFilterAsync(1, 10).ConfigureAwait(false));

            return policy.Result.ToDto().ToList();
        }

        public async Task<UserDto> GetByUsernameAsync(string username)
        {
            var user = await _unitOfWork.UsersRepository.GetByUsernameAsync(username).ConfigureAwait(false);

            return user.ToDto();
        }
    }
}
