using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Mpc.WinFormsIoC.Application.Services.Configuration;
using Mpc.WinFormsIoC.Data.Ef.Configuration;
using Mpc.WinFormsIoC.Infrastructure.CrossCutting.Settings;
using Mpc.WinFormsIoC.WebApi.Configuration;

namespace Mpc.WinFormsIoC.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettings = this.Configuration.Get<AppSettings>();

            services.AddControllers();

            services
                .ConfigureApplicationServices(appSettings)
                .ConfigureDataEf(appSettings)
                .ConfigureSwagger(appSettings);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app
                .UseHttpsRedirection()
                .AppConfigureSwagger();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
