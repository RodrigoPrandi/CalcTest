﻿using Microsoft.AspNetCore.Mvc;

namespace CalcTest.WebApi.Controllers
{
    public abstract class ApiController : ControllerBase
    {
        protected new IActionResult Response<T>(T result)
        {
            return Ok(result);
        }
    }
}
