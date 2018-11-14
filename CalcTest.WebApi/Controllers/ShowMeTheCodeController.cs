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
    public class ShowMeTheCodeController : ApiController
    {
        // GET: api/ShowMeTheCode
        [HttpGet]
        public IActionResult Get()
        {
            return Response("https://github.com/RodrigoPrandi/CalcTest");
        }
    }
}
