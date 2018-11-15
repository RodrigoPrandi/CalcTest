using CalcTest.Application.Services;
using CalcTest.Application.Services.Interfaces;
using CalcTest.Domain.Business;
using CalcTest.Domain.Business.Factory;
using CalcTest.Domain.Business.Factory.Interfaces;
using CalcTest.Domain.Business.Interfaces;
using CalcTest.Domain.Repository;
using CalcTest.Domain.Services;
using CalcTest.Domain.Services.Interfaces;
using CalcTest.Infra.Data.InMemory.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CalcTest.Infra.CrossCutting.IoC
{
    /// <summary>
    /// Classe reponsável por realizar a injeção de dependências
    /// </summary>
    public class InjectDependencies
    {
        /// <summary>
        /// Registra a injeção de dependência no serviço
        /// </summary>
        /// <param name="services">Service collection</param>
        public static void RegisterServices(IServiceCollection services)
        {
            //Repository InMemory
            services.AddScoped<ITaxaDeJurosRepository, TaxaDeJurosRepositoryInMemory>();

            // Domain Business Factory
            services.AddScoped<ICalculoDeJurosFactory, CalculoDeJurosFactory>();

            // Domain Business 
            services.AddScoped<ICalculoDeJuros, CalculoDeJuros>();

            // Domain Business Services
            services.AddScoped<ICalculoDeJurosServices, CalculoDeJurosServices>();

            //Application Service
            services.AddScoped<ICalculoDeJurosApplicationService, CalculoDeJurosApplicationService>();
        }
    }
}
