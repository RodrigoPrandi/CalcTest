using Microsoft.AspNetCore.Mvc;

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
        /// Teste Retorna a url de onde se encontra o fonte do projeto no GitHub
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
        public ActionResult<string> Get()
        {
            return Response("https://github.com/RodrigoPrandi/CalcTest");
        }
    }
}
