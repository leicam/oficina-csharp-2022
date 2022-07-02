using Facec.Dominio.Entidades;
using Facec.Dominio.Interfaces;
using Facec.Servicos.Classes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Facec.Apresentacao.Controllers
{
    [Route("usuario")]
    public class UsuarioController : AbstractController
    {
        private readonly IUsuarioServico _servico;

        public UsuarioController(IUsuarioServico servico)
        {
            _servico = servico;
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        public IActionResult Get()
            => InvokeMethod(_servico.GetAll);

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
            => InvokeMethod(_servico.Add, usuario);
    }
}