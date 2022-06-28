using Microsoft.AspNetCore.Mvc;
using System;

namespace Facec.Minha.Primeira.Api.Controllers
{
    [Route("hello")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok("Hello world!!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}