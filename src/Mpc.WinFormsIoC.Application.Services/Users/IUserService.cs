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
        Task<UserDto> CreateAsync(UserDto user);

        /// <summary>
        /// Find user by Id
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        Task<UserDto> FindAsync(int userId);

        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        Task<List<UserDto>> GetAllAsync();

        /// <summary>
        /// Find by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Returns the name</returns>
        Task<UserDto> GetByUsernameAsync(string username);

        /// <summary>
        /// Login user by username and password
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<bool> LoginAsync(string username, string password);

        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task UpdateAsync(UserDto user);
    }
}
