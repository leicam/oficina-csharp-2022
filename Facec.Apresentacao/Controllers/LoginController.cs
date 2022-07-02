using Facec.Dominio.Entidades;
using Facec.Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Facec.Apresentacao.Controllers
{
    [Route("login")]
    public class LoginController : AbstractController
    {
        private readonly ILoginServico _servico;

        public LoginController(ILoginServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
            => InvokeMethod(_servico.Autenticacao, usuario);
    }
}