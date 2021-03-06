using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Facec.Dominio.Entidades
{
    public class Usuario : AbstractEntidade
    {
        //criar propriedade prop + tab + tab

        [JsonPropertyName("login")]
        public string Login { get; private set; }

        [JsonPropertyName("password")]
        public string Senha { get; private set; }

        [JsonPropertyName("role")]
        public string Role { get; private set; }

        //criar construtor ctor + tab + tab

        [JsonConstructor]
        public Usuario(string login, string senha) : base()
        {
            Login = login;
            Senha = senha;
            Role = "padrao";
        }

        public Usuario(string login, string senha, string role) : base()
        {
            Login = login;
            Senha = senha;
            Role = role;
        }
    }
}