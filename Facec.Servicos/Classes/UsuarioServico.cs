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

        public void Add(Usuario usuario) 
            => _lista.Add(usuario);

        public ICollection<Usuario> GetAll() => _lista;
    }
}