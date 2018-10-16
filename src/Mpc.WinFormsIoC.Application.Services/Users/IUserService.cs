namespace Mpc.WinFormsIoC.Application.Services.Users
{
    using System.Threading.Tasks;

    public interface IUserService
    {
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        Task CreateAsync(string username, string name);

        /// <summary>
        /// Find a name by username
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Returns the name</returns>
        Task<string> GetNameAsync(string username);
    }
}
