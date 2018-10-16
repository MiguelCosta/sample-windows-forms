namespace Mpc.WinFormsIoC.Application.Services.Configuration
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Mpc.WinFormsIoC.Application.Services.Users;

    public static class DependenciesConfiguration
    {
        public static IServiceCollection ConfigureApplicationServices(IServiceCollection services, IConfigurationRoot configuration)
        {
            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}
