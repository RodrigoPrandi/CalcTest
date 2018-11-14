using System;
using CalcTest.Domain.Business.Factory.Interfaces;
using CalcTest.Domain.Business.Interfaces;
using CalcTest.Domain.Repository;

namespace CalcTest.Domain.Business.Factory
{
    public class CalculoDeJurosFactory : ICalculoDeJurosFactory
    {
        private readonly ITaxaDeJurosRepository _taxaDeJurosRepository;

        public CalculoDeJurosFactory(ITaxaDeJurosRepository taxaDeJurosRepository)
        {
            _taxaDeJurosRepository = taxaDeJurosRepository;
        }
        public ICalculoDeJuros Build()
        {
            throw new NotImplementedException();
        }
    }
}
