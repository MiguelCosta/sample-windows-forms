namespace Mpc.WinFormsIoC.Data.Ef.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;
    using Mpc.WinFormsIoC.Domain.Models;

    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext _context;

        public UsersRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<int> CountAsync()
        {
            return _context.Users.CountAsync();
        }

        public void Delete(int userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserModel> FindAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<UserModel>> GetByFilter(int page, int pageSize)
        {
            return _context.Users.ToListAsync();
        }

        public void Insert(UserModel user)
        {
            _context.Users.Add(user);
        }

        public void Update(UserModel user)
        {
            throw new System.NotImplementedException();
        }
    }
}
