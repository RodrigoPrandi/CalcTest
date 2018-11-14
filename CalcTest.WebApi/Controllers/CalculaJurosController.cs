using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcTest.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CalculaJurosController : ApiController
    {
        // GET: api/ShowMeTheCode
        [HttpGet]
        public IActionResult Get(decimal valorInicial, int meses)
        {
            return Response(0);
        }
    }
}
