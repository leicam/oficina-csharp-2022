using Facec.Dominio.Classes;
using Facec.Dominio.Entidades;
using Facec.Dominio.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;

namespace Facec.Servicos.Classes
{
    public class LoginServico : ILoginServico
    {
        private readonly JwtSecurityTokenHandler _handler = new JwtSecurityTokenHandler();
        private readonly IUsuarioServico _usuarioServico;

        public LoginServico(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        public string Autenticacao(Usuario usuario)
        {
            usuario = _usuarioServico.GetAll().FirstOrDefault(x
                => x.Login == usuario.Login
                && x.Senha == usuario.Senha);

            if (usuario == null)
                throw new ApplicationException("Usuario não cadastrado!");

            return _handler.WriteToken(ObterToken(usuario));
        }

        private SecurityToken ObterToken(Usuario usuario)
            => _handler.CreateToken(ObterDescriptor(usuario));

        private SecurityTokenDescriptor ObterDescriptor(Usuario usuario)
            => new SecurityTokenDescriptor()
            {
                Subject = ObterClaims(usuario),
                Expires = DateTime.UtcNow.AddHours(8),
                SigningCredentials = ObterCredential(),
            };

        private SigningCredentials ObterCredential()
            => new SigningCredentials(
                new SymmetricSecurityKey(Configuracao.ObterChave()),
                SecurityAlgorithms.HmacSha256Signature);

        private ClaimsIdentity ObterClaims(Usuario usuario)
            => new ClaimsIdentity(new[]
            {
                new Claim("id", usuario.Id.ToString()),
                new Claim(ClaimTypes.Role, usuario.Role),
            });
    }
}