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
            return _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Id == id);
        }

        public Task<List<UserModel>> GetByFilterAsync(int page, int pageSize)
        {
            return _context.Users
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<UserModel> GetByUsernameAndPasswordAsync(string username, string password)
        {
            return _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Username == username && x.Password == password);
        }

        public Task<UserModel> GetByUsernameAsync(string username)
        {
            return _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.Username == username);
        }

        public Task InsertAsync(UserModel user)
        {
            return _context.Users.AddAsync(user);
        }

        public void Update(UserModel user)
        {
            _context.Entry(user).State = EntityState.Modified;
        }
    }
}
