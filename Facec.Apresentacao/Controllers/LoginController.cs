using Facec.Dominio.Entidades;
using Facec.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Facec.Apresentacao.Controllers
{
    [Route("login")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginServico _servico;

        public LoginController(ILoginServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                return Ok(_servico.Autenticacao(usuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}