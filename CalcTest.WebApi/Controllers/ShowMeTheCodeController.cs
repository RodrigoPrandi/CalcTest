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
    public class ShowMeTheCodeController : ControllerBase
    {
        // GET: api/ShowMeTheCode
        [HttpGet]
        public string Get()
        {
            return "https://github.com/RodrigoPrandi/CalcTest";
        }
    }
}
