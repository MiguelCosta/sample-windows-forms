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

        void Insert(UserModel user);

        void Update(UserModel user);
    }
}
