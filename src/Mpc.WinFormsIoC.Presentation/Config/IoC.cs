namespace Mpc.WinFormsIoC.Presentation.Config
{
    using System.Windows.Forms;
    using Microsoft.Extensions.DependencyInjection;

    public static class IoC
    {
        private static ServiceProvider ServiceProvider = null;

        public static T GetForm<T>() where T : Form
        {
            return ServiceProvider.GetService<T>();
        }

        public static void Init()
        {
            var services = new ServiceCollection();
            RegisterForms(services);

            WinFormsIoC.Application.Services.Configuration.DependenciesConfiguration.ConfigureApplicationServices(services, null);

            ServiceProvider = services.BuildServiceProvider();
        }

        private static void RegisterForms(IServiceCollection services)
        {
            services.AddSingleton<FrmMain>();
            services.AddTransient<Users.FrmUserEdit>();
        }
    }
}
