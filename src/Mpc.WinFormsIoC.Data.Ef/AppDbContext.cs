namespace Mpc.WinFormsIoC.Data.Ef
{
    using Microsoft.EntityFrameworkCore;
    using Mpc.WinFormsIoC.Data.Ef.Mappings;
    using Mpc.WinFormsIoC.Data.Ef.Mappings.Configuration;
    using Mpc.WinFormsIoC.Domain.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<CountryModel> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new UserMapping());
            modelBuilder.AddConfiguration(new CountryMapping());
        }
    }
}
