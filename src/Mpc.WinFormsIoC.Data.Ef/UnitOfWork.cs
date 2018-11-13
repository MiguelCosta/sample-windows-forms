namespace Mpc.WinFormsIoC.Data.Ef
{
    using System.Threading.Tasks;
    using Mpc.WinFormsIoC.Domain.Core;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            UsersRepository = new Repositories.UsersRepository(_context);
            CountriesRepository = new Repositories.CountriesRepository(_context);
        }

        public IUsersRepository UsersRepository { get; }

        public ICountriesRepository CountriesRepository { get; }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
