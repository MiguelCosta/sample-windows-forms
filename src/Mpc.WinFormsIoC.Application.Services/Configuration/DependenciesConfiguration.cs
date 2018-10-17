namespace Mpc.WinFormsIoC.Application.Services.Configuration
{
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.WinFormsIoC.Application.Services.Users;
    using Mpc.WinFormsIoC.Data.Ef.Configuration;
    using Mpc.WinFormsIoC.Infrastructure.CrossCutting.Settings;

    public static class DependenciesConfiguration
    {
        public static IServiceCollection ConfigureApplicationServices(IServiceCollection services, AppSettings appSettings)
        {
            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}
