using System;
using System.Net.Http;
using CalcTest.Domain.Models;
using CalcTest.Domain.Services.Interfaces;
using CalcTest.Infra.Services.Config;
using Microsoft.Extensions.Options;

namespace CalcTest.Infra.Services.Services
{
    /// <summary>
    /// Serviço que consulta taxa de juros no microserviço
    /// </summary>
    public class TaxaDeJurosServices : ITaxaDeJurosServices
    {
        private readonly ApiTaxaJurosConfiguration apiTaxaJurosConfiguration;

        public TaxaDeJurosServices(IOptions<ApiTaxaJurosConfiguration> apiTaxaJurosConfiguration)
        {
            this.apiTaxaJurosConfiguration = apiTaxaJurosConfiguration.Value;
        }

        public TaxaDeJuros SelecionarTaxaDeJurosAtualizada()
        {
            var urlEndpoint = $"http://{apiTaxaJurosConfiguration.UrlTaxaJuros}/taxaJuros";

            var client = new HttpClient();

            var response = client.GetAsync(urlEndpoint).Result;

            decimal taxaJuros = 0;

            if (response.IsSuccessStatusCode)
                taxaJuros = Convert.ToDecimal(response.Content.ReadAsStringAsync().Result);

            return new TaxaDeJuros
            {
                JurosEfetivo = taxaJuros
            };
        }
    }
}
