using CalcTest.Domain.Business.Factory.Interfaces;
using CalcTest.Domain.Business.Interfaces;
using CalcTest.Domain.Services;
using NSubstitute;
using NUnit.Framework;

namespace CalcTest.Domain.Test.Services
{
    [TestFixture]
    class CalculoDeJurosServicesTest
    {
        private const decimal VALORINICIAL = 105;
        private const int QUANTIDADEMESES = 5;
        private const double RESULTADO = 106;

        [Test]
        public void DeveConstruirRegraDeNegocioPeloCalculoDeJurosFactoryAoRealizarOCalculo()
        {
            var calculoDeJurosFactoryMock = Substitute.For<ICalculoDeJurosFactory>();

            var calculoDeJurosService = new CalculoDeJurosServices(calculoDeJurosFactoryMock);
            calculoDeJurosService.Calcular(1,2);

            calculoDeJurosFactoryMock.Received(1).CreateCalculoDeJurosCompostos();
        }

        [Test]
        public void MetodoCalcularDoServicoDeverRetornarOResultadoDoMetodoCalcularDaRegraDeNegocioCriadaPeloFactory()
        {
            var calculoDeJurosFactoryMock = Substitute.For<ICalculoDeJurosFactory>();
            var calculoDeJurosBusinessMock = Substitute.For<ICalculoDeJuros>();
            calculoDeJurosBusinessMock.Calcular(VALORINICIAL, QUANTIDADEMESES).Returns(RESULTADO);
            calculoDeJurosFactoryMock.CreateCalculoDeJurosCompostos().Returns(calculoDeJurosBusinessMock);

            var calculoDeJurosService = new CalculoDeJurosServices(calculoDeJurosFactoryMock);
            var resultadoServico = calculoDeJurosService.Calcular(VALORINICIAL, QUANTIDADEMESES);

            Assert.AreEqual(RESULTADO, resultadoServico);
        }
    }
}
