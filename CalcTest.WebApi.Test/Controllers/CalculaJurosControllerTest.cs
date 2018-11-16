using CalcTest.Application.Services.Interfaces;
using CalcTest.Infra.CrossCutting.Extensions;
using CalcTest.Infra.CrossCutting.IoC;
using CalcTest.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace CalcTest.WebApi.Test.Controllers
{
    [TestFixture]
    class CalculaJurosControllerTest
    {
        private CalculaJurosController _calculaJurosController;

        [SetUp]
        public void SetUp()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            InjectDependencies.RegisterServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            var apllicationService = serviceProvider.GetService<ICalculoDeJurosApplicationService>();
            _calculaJurosController = new CalculaJurosController(apllicationService);
        }

        [Test]
        public void TestarValorInicial100Meses5()
        {
            var resultado = _calculaJurosController.Get(100, 5);

            Assert.IsInstanceOf(typeof(OkObjectResult), resultado.Result);

            var okResult = resultado.Result as OkObjectResult;

            Assert.AreEqual("105,10", okResult.Value);            
        }

        [Test]
        public void TestarValorInicial0Meses0()
        {
            var resultado = _calculaJurosController.Get(0, 0);

            Assert.IsInstanceOf(typeof(OkObjectResult), resultado.Result);

            var okResult = resultado.Result as OkObjectResult;
            Assert.AreEqual("0,00", okResult.Value);
        }

        [Test]
        public void TestarValorInicial100Meses0()
        {
            var resultado = _calculaJurosController.Get(100, 0);

            Assert.IsInstanceOf(typeof(OkObjectResult), resultado.Result);

            var okResult = resultado.Result as OkObjectResult;
            Assert.AreEqual("100,00", okResult.Value);
        }

        [Test]
        public void TestarValorInicial1023_1265Meses0()
        {
            var resultado = _calculaJurosController.Get(1023.1265m, 0);

            Assert.IsInstanceOf(typeof(OkObjectResult), resultado.Result);

            var okResult = resultado.Result as OkObjectResult;
            Assert.AreEqual("1023,12", okResult.Value);
        }

        [Test]
        public void TestarValorInicial165Meses25()
        {
            var resultado = _calculaJurosController.Get(165, 25);

            Assert.IsInstanceOf(typeof(OkObjectResult), resultado.Result);

            var okResult = resultado.Result as OkObjectResult;
            Assert.AreEqual("211,60", okResult.Value);
        }

        [Test]
        public void TestarValorInicial165Meses125()
        {
            var resultado = _calculaJurosController.Get(165, 125);

            Assert.IsInstanceOf(typeof(OkObjectResult), resultado.Result);

            var okResult = resultado.Result as OkObjectResult;
            Assert.AreEqual("572,34", okResult.Value);
        }

        [Test]
        public void TestarValorInicial169Meses125()
        {
            var resultado = _calculaJurosController.Get(169, 125);

            Assert.IsInstanceOf(typeof(OkObjectResult), resultado.Result);

            var okResult = resultado.Result as OkObjectResult;
            Assert.AreEqual("586,21", okResult.Value);
        }
    }
}
