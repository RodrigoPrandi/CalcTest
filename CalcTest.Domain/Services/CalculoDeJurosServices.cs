using System;
using CalcTest.Domain.Business.Factory.Interfaces;
using CalcTest.Domain.Services.Interfaces;

namespace CalcTest.Domain.Services
{
    /// <summary>
    /// Serviço de cálculo de juros compostos
    /// </summary>
    public class CalculoDeJurosServices : ICalculoDeJurosServices
    {
        private readonly ICalculoDeJurosFactory _calculoDeJurosFactory;

        /// <summary>
        /// Construtor do serviço cálculo de juros
        /// </summary>
        /// <param name="calculoDeJurosFactory">Factory responsável por criar a regra de cálculo de juros</param>
        public CalculoDeJurosServices(ICalculoDeJurosFactory calculoDeJurosFactory)
        {
            _calculoDeJurosFactory = calculoDeJurosFactory;
        }

        /// <summary>
        /// Realiza o cálculo do valor total de juros a partir de um valor inicial
        /// e uma quantidade de meses especificada
        /// </summary>
        /// <param name="valorInicial">Valor inial a ser aplicado o juros </param>
        /// <param name="quantidadeMeses">Quantidade de meses a ser aplicado o juros</param>
        /// <returns>Valor final do calculo de juros pelos meses informado</returns>
        public decimal Calcular(decimal valorInicial, int quantidadeMeses)
        {
            var calculoDeJurosBusiness = _calculoDeJurosFactory.Build();
            return calculoDeJurosBusiness.Calcular(valorInicial, quantidadeMeses);
        }
    }
}
