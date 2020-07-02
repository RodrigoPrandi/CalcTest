using System;
using System.Net.Http;
using CalcTest.Domain.Models;
using CalcTest.Domain.Services.Interfaces;

namespace CalcTest.Infra.Services.Services
{
    /// <summary>
    /// Serviço que consulta taxa de juros no microserviço
    /// </summary>
    public class TaxaDeJurosServices : ITaxaDeJurosServices
    {
        public TaxaDeJuros SelecionarTaxaDeJurosAtualizada()
        {
            var urlEndpoint = "https://localhost:44342/taxaJuros";

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
