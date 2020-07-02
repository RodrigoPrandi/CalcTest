using CalcTest.Domain.Business;
using CalcTest.Domain.Business.Factory;
using CalcTest.Domain.Models;
using CalcTest.Domain.Services.Interfaces;
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
            var taxaDeJurosServices = Substitute.For<ITaxaDeJurosServices>();
            taxaDeJurosServices.SelecionarTaxaDeJurosAtualizada().Returns(taxadeJuros);

            var calculoDeJurosService = new CalculoDeJurosFactory(taxaDeJurosServices);
            var calculoDeJuros = calculoDeJurosService.CreateCalculoDeJurosCompostos();

            taxaDeJurosServices.Received(1).SelecionarTaxaDeJurosAtualizada();

            Assert.IsTrue(calculoDeJuros is CalculoDeJuros);
            Assert.AreEqual(taxadeJuros, calculoDeJuros.TaxaAplicada);
        }
    }
}
