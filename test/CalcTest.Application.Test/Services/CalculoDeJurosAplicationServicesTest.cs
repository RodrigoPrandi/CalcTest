using CalcTest.Application.Services.Interfaces;
using CalcTest.Infra.CrossCutting.IoC;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CalcTest.Domain.Test.Services
{
    [TestFixture]
    class CalculoDeJurosAplicationServicesTest
    {
        private ICalculoDeJurosApplicationService _calculoDeJurosApplicationService;

        [SetUp]
        public void SetUp()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            InjectDependencies.RegisterServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            _calculoDeJurosApplicationService = serviceProvider.GetService<ICalculoDeJurosApplicationService>();
        }

        [Test]
        public void TestarValorInicial100Meses5()
        {
            var resultado = _calculoDeJurosApplicationService.Calcular(100, 5);
            Assert.AreEqual(105.10m, resultado);
        }

        [Test]
        public void TestarValorInicial0Meses0()
        {
            var resultado = _calculoDeJurosApplicationService.Calcular(0, 0);
            Assert.AreEqual(0, resultado);
        }

        [Test]
        public void TestarValorInicial100Meses0()
        {
            var resultado = _calculoDeJurosApplicationService.Calcular(100, 0);
            Assert.AreEqual(100, resultado);
        }

        [Test]
        public void TestarValorInicial1023_1265Meses0()
        {
            var resultado = _calculoDeJurosApplicationService.Calcular(1023.1265m, 0);
            Assert.AreEqual(1023.12m, resultado);
        }

        [Test]
        public void TestarValorInicial165Meses25()
        {
            var resultado = _calculoDeJurosApplicationService.Calcular(165, 25);
            Assert.AreEqual(211.60m, resultado);
        }

        [Test]
        public void TestarValorInicial165Meses125()
        {
            var resultado = _calculoDeJurosApplicationService.Calcular(165, 125);
            Assert.AreEqual(572.34m, resultado);
        }

        [Test]
        public void TestarValorInicial169Meses125()
        {
            var resultado = _calculoDeJurosApplicationService.Calcular(169, 125);
            Assert.AreEqual(586.21m, resultado);
        }
    }
}
