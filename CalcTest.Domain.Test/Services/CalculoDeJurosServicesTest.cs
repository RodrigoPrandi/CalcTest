using CalcTest.Domain.Business.Factory.Interfaces;
using CalcTest.Domain.Business.Interfaces;
using CalcTest.Domain.Services;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalcTest.Domain.Test.Services
{
    [TestFixture]
    class CalculoDeJurosServicesTest
    {
        private const decimal VALORINICIAL = 105;
        private const int QUANTIDADEMESES = 5;
        private const decimal RESULTADO = 106;

        [Test]
        public void DeveConstruirRegraDeNegocioPeloCalculoDeJurosFactory()
        {
            var calculoDeJurosFactoryMock = Substitute.For<ICalculoDeJurosFactory>();

            var calculoDeJurosService = new CalculoDeJurosServices(calculoDeJurosFactoryMock);

            calculoDeJurosFactoryMock.Received(1).Build();
        }

        [Test]
        public void MetodoCalcularDoServicoDeverRetornarOResultadoDoMetodoCalcularDaRegraDeNegocioCriadaPeloFactory()
        {
            var calculoDeJurosFactoryMock = Substitute.For<ICalculoDeJurosFactory>();
            var calculoDeJurosBusinessMock = Substitute.For<ICalculoDeJuros>();
            calculoDeJurosBusinessMock.Calcular(VALORINICIAL, QUANTIDADEMESES).Returns(RESULTADO);
            calculoDeJurosFactoryMock.Build().Returns(calculoDeJurosBusinessMock);

            var calculoDeJurosService = new CalculoDeJurosServices(calculoDeJurosFactoryMock);
            var resultadoServico = calculoDeJurosService.Calcular(VALORINICIAL, QUANTIDADEMESES);

            Assert.AreEqual(RESULTADO, resultadoServico);
        }
    }
}
