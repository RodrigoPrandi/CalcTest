using CalcTest.Application.Services.Interfaces;
using CalcTest.Infra.CrossCutting.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace CalcTest.WebApi.Controllers
{
    /// <summary>
    /// Contoller cálculo de juros
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ApiController
    {
        private readonly ICalculoDeJurosApplicationService _calculoDeJurosService;

        public CalculaJurosController(ICalculoDeJurosApplicationService calculoDeJurosService)
        {
            _calculoDeJurosService = calculoDeJurosService;
        }

        /// <summary>
        /// Faz o cálculo de juros compostos em memória, conforme seguinte regra: 
        /// Valor Final = Valor Inicial * (1 + juros) ^ Tempo.
        ///  O juros aplicado será de 1%.
        /// </summary>
        /// <remarks>
        /// Exemplo request:
        ///
        ///     GET /calculajuros?valorinicial=100&amp;meses=5 
        ///
        /// </remarks>
        /// <param name="valorInicial">Valor inicial a ser aplicado juros</param>
        /// <param name="meses">Quantidade de meses a ser aplicado juros</param>
        /// <returns>O resultado será o valor truncado do cálculo sem arredondamento, formatado com duas casas decimais.</returns>
        /// <response code="200">O resultado será o valor truncado do cálculo sem arredondamento, formatado com duas casas decimais</response>
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<string> Get(decimal valorInicial, int meses)
        {
            var resultado = _calculoDeJurosService.Calcular(valorInicial, meses);
            
            return Response(resultado.FormartStringBr());
        }
    }
}
