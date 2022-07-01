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
        private readonly List<Usuario> _lista = new List<Usuario>();

        public UsuarioServico()
        {
            _lista.Add(new Usuario("juliano", "123", "admin"));
        }

        public void Add(Usuario usuario)
        {
            if (_lista.FirstOrDefault(x => x.Login == usuario.Login)
                != null)
                throw new ApplicationException("Usuário já cadastrado!");

            _lista.Add(usuario);
        }

        public ICollection<Usuario> GetAll() => _lista;
    }
}