using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facec.Dominio.Classes
{
    public static class Configuracao
    {
        public static string ObterSegredo() => "ETerIMENGuitaTeROnelUMIcIfELabOLAThqUashbOrdtIOGre";
        public static byte[] ObterChave() => Encoding.ASCII.GetBytes(ObterSegredo());
    }
}