using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Facec.Dominio.Entidades
{
    public  class AbstractEntidade
    {
        [JsonPropertyName("id")]
        public Guid Id { get; private set; }

        protected AbstractEntidade()
        {
            Id = Guid.NewGuid();
        }
    }
}
