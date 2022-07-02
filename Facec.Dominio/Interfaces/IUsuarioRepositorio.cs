using Facec.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Dominio.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Usuario Add(Usuario usuario);
        ICollection<Usuario> GetAll();
    }
}