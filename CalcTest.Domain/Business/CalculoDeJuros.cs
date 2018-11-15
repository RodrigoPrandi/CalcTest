using System;
using CalcTest.Domain.Business.Interfaces;
using CalcTest.Domain.Models;

namespace CalcTest.Domain.Business
{
    public class CalculoDeJuros : ICalculoDeJuros
    {
        /// <summary>
        /// Taxa de juros aplicada no calculo
        /// </summary>
        public TaxaDeJuros TaxaAplicada { get; }

        public CalculoDeJuros(TaxaDeJuros taxaDeJuros)
        {
            TaxaAplicada = taxaDeJuros;
        }

        public decimal Calcular(decimal valorInicial, int quantidadeMeses)
        {
            throw new NotImplementedException();
        }
    }
}
