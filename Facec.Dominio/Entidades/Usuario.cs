using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Dominio.Entidades
{
    public class Usuario
    {
        //criar propriedade prop + tab + tab
        public string Login { get; private set; }
        public string Senha { get; private set; }

        //criar construtor ctor + tab + tab
        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
    }
}