using CalcTest.Domain.Business;
using CalcTest.Domain.Business.Factory;
using CalcTest.Domain.Models;
using CalcTest.Domain.Repository;
using NSubstitute;
using NUnit.Framework;

namespace CalcTest.Domain.Test.Business.Factory
{
    [TestFixture]
    class CalculoDeJurosFactoryTest
    {
        [Test]
        public void ValidarFactoryDeJurosCompostosInicializaClasseDeCalcuoDeJurosComATaxaAtualizada()
        {
            var taxadeJuros = new TaxaDeJuros();
            var taxaDeJurosRepository = Substitute.For<ITaxaDeJurosRepository>();
            taxaDeJurosRepository.SelecionarTaxaDeJurosAtualizada().Returns(taxadeJuros);

            var calculoDeJurosService = new CalculoDeJurosFactory(taxaDeJurosRepository);
            var calculoDeJuros = calculoDeJurosService.CreateCalculoDeJurosCompostos();

            taxaDeJurosRepository.Received(1).SelecionarTaxaDeJurosAtualizada();

            Assert.IsTrue(calculoDeJuros is CalculoDeJuros);
            Assert.AreEqual(taxadeJuros, calculoDeJuros.TaxaAplicada);
        }
    }
}
