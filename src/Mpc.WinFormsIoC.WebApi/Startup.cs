using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var appSettings = this.Configuration.Get<AppSettings>();

            services
                .ConfigureApplicationServices(appSettings)
                .ConfigureDataEf(appSettings)
                .ConfigureSwagger(appSettings);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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
                .UseMvc()
                .AppConfigureSwagger();
        }
    }
}
