namespace Mpc.WinFormsIoC.Application.Services.Users
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Application.Dto;

    public interface IUserService
    {
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        Task CreateAsync(UserDto user);

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        Task<List<UserDto>> GetAllAsync();

        /// <summary>
        /// Find a name by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Returns the name</returns>
        Task<UserDto> GetByUsernameAsync(string username);
    }
}
