using CalcTest.Infra.CrossCutting.Config;
using CalcTest.Infra.CrossCutting.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace CalcTest.WebApi
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
            services.AddControllers();

            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "CalcTest WebApi",
                    Description = "WebApi contendo endpoints para avaliação do novo SoftPlayer!",
                    Contact = new OpenApiContact { Name = "Rodrigo Prandi Araújo", Email = "rodrigo.prandi@outlook.com" }
                });
                
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                s.IncludeXmlComments(xmlPath);
            });

            RegisterDependencies(services);

            RegisterConfiguration(services);
        }

        private void RegisterConfiguration(IServiceCollection services)
        {
            InjectConfiguration.RegisterConfiguration(services, Configuration);
        }

        private void RegisterDependencies(IServiceCollection services)
        {
            InjectDependencies.RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "CalcTest WebApi");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
