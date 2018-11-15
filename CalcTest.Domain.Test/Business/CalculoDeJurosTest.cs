using CalcTest.Domain.Business;
using CalcTest.Domain.Models;
using NUnit.Framework;

namespace CalcTest.Domain.Test.Business
{
    [TestFixture]
    class CalculoDeJurosTest
    {
        private CalculoDeJuros _calculoDeJurosBusiness;

        [SetUp]
        public void SetUp()
        {
            var taxaDeJuros = new TaxaDeJuros { JurosEfetivo = 1 };

            _calculoDeJurosBusiness = new CalculoDeJuros(taxaDeJuros);
        }

        [Test]
        public void TestandoCenarioDaProva()
        {
            var resultadoCalculo = _calculoDeJurosBusiness.Calcular(100, 5);

            Assert.AreEqual(105.1m, resultadoCalculo);
        }

        [Test]
        public void TestarValorInicial0Meses0()
        {
            var resultado = _calculoDeJurosBusiness.Calcular(0, 0);
            Assert.AreEqual(0, resultado);
        }

        [Test]
        public void TestarValorInicial100Meses0()
        {
            var resultado = _calculoDeJurosBusiness.Calcular(100, 0);
            Assert.AreEqual(100, resultado);
        }

        [Test]
        public void TestarValorInicial1023_1265Meses0()
        {
            var resultado = _calculoDeJurosBusiness.Calcular(1023.1265m, 0);
            Assert.AreEqual(1023.12m, resultado);
        }

        [Test]
        public void TestarValorInicial165Meses25()
        {
            var resultado = _calculoDeJurosBusiness.Calcular(165, 25);
            Assert.AreEqual(211.60m, resultado);
        }

        [Test]
        public void TestarValorInicial165Meses125()
        {
            var resultado = _calculoDeJurosBusiness.Calcular(165, 125);
            Assert.AreEqual(572.34m, resultado);
        }

        [Test]
        public void TestarValorInicial169Meses125()
        {
            var resultado = _calculoDeJurosBusiness.Calcular(169, 125);
            Assert.AreEqual(586.21m, resultado);
        }
    }
}
