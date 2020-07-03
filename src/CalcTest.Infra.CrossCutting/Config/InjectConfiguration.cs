using CalcTest.Infra.Services.Config;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcTest.Infra.CrossCutting.Config
{
    public class InjectConfiguration
    {
        public static void RegisterConfiguration(IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();
            services.Configure<ApiTaxaJurosConfiguration>(configuration);
        }
    }
}
