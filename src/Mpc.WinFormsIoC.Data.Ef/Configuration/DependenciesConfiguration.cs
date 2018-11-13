namespace Mpc.WinFormsIoC.Data.Ef.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.WinFormsIoC.Data.Ef.Repositories;
    using Mpc.WinFormsIoC.Domain.Core;
    using Mpc.WinFormsIoC.Domain.Core.Repositories;
    using Mpc.WinFormsIoC.Infrastructure.CrossCutting.Settings;

    public static class DependenciesConfiguration
    {
        public static IServiceCollection ConfigureDataEf(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddDbContext<AppDbContext>(
                options => options.UseSqlServer(appSettings.DataBaseSettings.ConnectionString));

            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUsersRepository, UsersRepository>();
            services.AddTransient<ICountriesRepository, CountriesRepository>();

            return services;
        }
    }
}
