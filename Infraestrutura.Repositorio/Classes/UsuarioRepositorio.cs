using Facec.Dominio.Entidades;
using Facec.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Repositorio.Classes
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly List<Usuario> _lista = new List<Usuario>();

        public UsuarioRepositorio()
        {
            _lista.Add(new Usuario("juliano", "123", "admin"));
        }

        public Usuario Add(Usuario usuario)
        {
            _lista.Add(usuario);
            return usuario;
        }

        public ICollection<Usuario> GetAll() => _lista;
    }
}
