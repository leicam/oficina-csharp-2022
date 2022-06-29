using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Facec.Dominio.Entidades
{
    public class Usuario
    {
        //criar propriedade prop + tab + tab

        [JsonPropertyName("login")]
        public string Login { get; private set; }

        [JsonPropertyName("password")]
        public string Senha { get; private set; }

        //criar construtor ctor + tab + tab

        [JsonConstructor]
        public Usuario(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }
    }
}