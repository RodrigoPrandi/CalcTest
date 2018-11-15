using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcTest.WebApi.Controllers
{
    /// <summary>
    /// Controller responsável por mostrar o link do código fonte no GitHub
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class ShowMeTheCodeController : ApiController
    {
        /// <summary>
        /// Retorna a url de onde se encontra o fonde do projeto no GitHub
        /// </summary>
        /// <returns>Url do código fonte no GitHub</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Response("https://github.com/RodrigoPrandi/CalcTest");
        }
    }
}
