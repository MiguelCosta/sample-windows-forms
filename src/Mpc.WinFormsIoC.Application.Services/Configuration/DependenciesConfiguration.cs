namespace Mpc.WinFormsIoC.Application.Services.Configuration
{
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.WinFormsIoC.Application.Services.Countries;
    using Mpc.WinFormsIoC.Application.Services.Users;
    using Mpc.WinFormsIoC.Infrastructure.CrossCutting.Settings;

    public static class DependenciesConfiguration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ICountryService, CountryService>();

            return services;
        }
    }
}
