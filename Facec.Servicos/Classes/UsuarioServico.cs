using Facec.Dominio.Entidades;
using Facec.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Servicos.Classes
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _repositorio;

        public UsuarioServico(IUsuarioRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public Usuario Add(Usuario usuario)
        {
            if (_repositorio.GetAll()
                .FirstOrDefault(x => x.Login == usuario.Login)
                != null)
                throw new ApplicationException("Usuário já cadastrado!");

            _repositorio.Add(usuario);

            return usuario;
        }

        public ICollection<Usuario> GetAll() => _repositorio.GetAll();
    }
}