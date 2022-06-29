using Facec.Dominio.Entidades;
using Facec.Dominio.Interfaces;
using Facec.Servicos.Classes;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Facec.Apresentacao.Controllers
{
    [Route("usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServico _servico;

        public UsuarioController()
        {
            _servico = new UsuarioServico();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servico.GetAll());
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            try
            {
                _servico.Add(usuario);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}