using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalcTest.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        // GET: api/ShowMeTheCode
        [HttpGet]
        public decimal Get(decimal valorInicial, int meses)
        {
            return 0;
        }
    }
}
