using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Mpc.WinFormsIoC.Application.Dto;
using Mpc.WinFormsIoC.Infrastructure.CrossCutting.Settings;
using Swashbuckle.AspNetCore.Swagger;

namespace Mpc.WinFormsIoC.WebApi.Configuration
{
    internal static class SwaggerConfiguration
    {
        internal static IServiceCollection ConfigureSwagger(this IServiceCollection services, AppSettings appSettings)
        {
            var info = new Info
            {
                Version = "v1",
                Title = appSettings.AppName,
                Description = "My example of WinForms with IoC",
                Contact = new Contact
                {
                    Email = "miguelpintodacosta@gmail.com",
                    Name = "Miguel Costa",
                    Url = "https://github.com/MiguelCosta/sample-windows-forms"
                }
            };

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", info);

                var webApiDoc = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var dtoDoc = $"{Assembly.GetAssembly(typeof(UserDto)).GetName().Name}.xml";
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, webApiDoc));
                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, dtoDoc));

                c.DescribeAllEnumsAsStrings();
                c.DescribeAllParametersInCamelCase();
            });

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
