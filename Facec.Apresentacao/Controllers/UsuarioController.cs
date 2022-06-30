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

        public UsuarioController(IUsuarioServico servico)
        {
            _servico = servico;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_servico.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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