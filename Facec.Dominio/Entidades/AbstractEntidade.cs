using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Dominio.Entidades
{
    public  class AbstractEntidade
    {
        public Guid Id { get; private set; }

        public AbstractEntidade()
        {
            Id = Guid.NewGuid();
        }
    }
}
