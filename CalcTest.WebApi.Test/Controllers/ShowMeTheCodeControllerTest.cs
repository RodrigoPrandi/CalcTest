using CalcTest.Application.Services.Interfaces;
using CalcTest.Infra.CrossCutting.Extensions;
using CalcTest.Infra.CrossCutting.IoC;
using CalcTest.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using System.Net.Http;

namespace CalcTest.WebApi.Test.Controllers
{
    [TestFixture]
    class ShowMeTheCodeControllerTest
    {
        private ShowMeTheCodeController _showMeTheCodeController;

        [SetUp]
        public void SetUp()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            InjectDependencies.RegisterServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            _showMeTheCodeController = new ShowMeTheCodeController();
        }

        [Test]
        public void ValidarLinkCodigoFonte()
        {
            var resultado = _showMeTheCodeController.Get();

            Assert.IsInstanceOf(typeof(OkObjectResult), resultado.Result);

            var okResult = resultado.Result as OkObjectResult;

            Assert.AreEqual("https://github.com/RodrigoPrandi/CalcTest", okResult.Value);
        }
    }
}
