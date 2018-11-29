namespace Mpc.WinFormsIoC.Domain.Core.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Domain.Models;

    public interface IUsersRepository
    {
        Task<int> CountAsync();

        void Delete(int userId);

        Task<UserModel> FindAsync(int id);

        Task<List<UserModel>> GetByFilterAsync(int page, int pageSize);

        Task<UserModel> GetByUsernameAndPasswordAsync(string username, string password);

        Task<UserModel> GetByUsernameAsync(string username);

        Task InsertAsync(UserModel user);

        void Update(UserModel user);
    }
}
