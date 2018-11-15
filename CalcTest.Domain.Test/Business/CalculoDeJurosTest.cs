using CalcTest.Domain.Business;
using CalcTest.Domain.Models;
using NUnit.Framework;

namespace CalcTest.Domain.Test.Business
{
    [TestFixture]
    class CalculoDeJurosTest
    {
        [Test]
        public void TestandoCenarioDaProva()
        {
            var taxaDeJuros = new TaxaDeJuros { JurosEfetivo = 1 };

            var calculoDeJurosBusiness = new CalculoDeJuros(taxaDeJuros);
            var resultadoCalculo = calculoDeJurosBusiness.Calcular(100, 5);

            Assert.AreEqual(105.10, resultadoCalculo);
        }
    }
}
