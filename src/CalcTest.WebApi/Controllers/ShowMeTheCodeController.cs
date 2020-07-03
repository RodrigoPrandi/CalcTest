using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CalcTest.WebApi.Controllers
{
    /// <summary>
    /// Controller responsável por mostrar o link do código fonte no GitHub
    /// </summary>
    [Produces("application/json")]
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ApiController
    {
        /// <summary>
        /// Retorna a url de onde se encontra o fonte do projeto no GitHub
        /// </summary>
        /// <remarks>
        /// Exemplo request:
        ///
        ///     GET /showmethecode 
        ///
        /// </remarks>
        /// <returns>Url do código fonte no GitHub</returns>
        /// <response code="200">Url do código fonte no GitHub</response>
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<List<string>> Get()
        {
            return Response(new List<string> { "https://github.com/RodrigoPrandi/SoftPlanTest", "https://github.com/RodrigoPrandi/CalculaJurosApi", "https://github.com/RodrigoPrandi/TaxaJurosApi" });
        }
    }
}
