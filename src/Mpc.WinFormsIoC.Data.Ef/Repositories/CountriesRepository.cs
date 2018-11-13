namespace Mpc.WinFormsIoC.Data.Ef.Repositories
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.EntityFrameworkCore;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;
    using Mpc.WinFormsIoC.Domain.Models;

    internal class CountriesRepository : ICountriesRepository
    {
        private AppDbContext _context;

        public CountriesRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<CountryModel> FindAsync(int countryId)
        {
            return _context.Countries.FindAsync(countryId);
        }

        public Task<List<CountryModel>> GetAllAsync()
        {
            return _context.Countries.ToListAsync();
        }

        public Task InsertAsync(CountryModel country)
        {
            return _context.Countries.AddAsync(country);
        }
    }
}
