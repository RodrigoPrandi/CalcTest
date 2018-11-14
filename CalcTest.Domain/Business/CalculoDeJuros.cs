using System;
using CalcTest.Domain.Business.Interfaces;
using CalcTest.Domain.Models;

namespace CalcTest.Domain.Business
{
    class CalculoDeJuros : ICalculoDeJuros
    {
        private readonly TaxaDeJuros _taxaDeJuros;

        public CalculoDeJuros(TaxaDeJuros taxaDeJuros)
        {
            _taxaDeJuros = taxaDeJuros;
        }

        public decimal Calcular(decimal valorInicial, int quantidadeMeses)
        {
            throw new NotImplementedException();
        }
    }
}
