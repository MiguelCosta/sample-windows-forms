using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Infrastructure.CrossCutting.Settings;

namespace Mpc.WinFormsIoC.WebApi.Configuration
{
    internal static class SwaggerConfiguration
    {
        internal static IServiceCollection ConfigureSwagger(this IServiceCollection services, AppSettings appSettings)
        {
            var buildVersion = typeof(SwaggerConfiguration).GetTypeInfo().Assembly.GetName().Version;

            var info = new OpenApiInfo
            {
                Title = "My example of WinForms with IoC",
                Version = "v1",
                Description = $"Build Version: {buildVersion}",
                Contact = new OpenApiContact
                {
                    Email = "miguelpintodacosta@gmail.com",
                    Name = "Miguel Costa",
                    Url = new Uri("https://github.com/MiguelCosta/sample-windows-forms")
                }
            };

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", info);

                var webApiDoc = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var dtoDoc = $"{Assembly.GetAssembly(typeof(UserDto)).GetName().Name}.xml";
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, webApiDoc));
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, dtoDoc));

                c.DescribeAllParametersInCamelCase();
            });

            services.AddSwaggerGenNewtonsoftSupport();

            return services;
        }

        internal static IApplicationBuilder AppConfigureSwagger(this IApplicationBuilder app)
        {
            app
                .UseSwagger()
                .UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Documentation V1");
                    c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
                    c.DocumentTitle = "WinFormsIoC Documentation";
                    c.RoutePrefix = string.Empty;
                });

            return app;
        }
    }
}
