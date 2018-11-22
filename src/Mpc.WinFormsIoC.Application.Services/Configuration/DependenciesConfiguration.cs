namespace Mpc.WinFormsIoC.Application.Services.Configuration
{
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.WinFormsIoC.Application.Services.Countries;
    using Mpc.WinFormsIoC.Application.Services.Security;
    using Mpc.WinFormsIoC.Application.Services.Users;
    using Mpc.WinFormsIoC.Infrastructure.CrossCutting.Settings;

    public static class DependenciesConfiguration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddTransient<ICountryService, CountryService>();
            services.AddTransient<IEncryptText, EncryptTextSha1>();
            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}
