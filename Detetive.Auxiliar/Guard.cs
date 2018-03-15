using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Auxiliar
{
    public class Guard
    {
        public static void ParaNuloOuVazio(string valor, string msgErro)
        {
            if (string.IsNullOrEmpty(valor))
                throw new Exception(msgErro);
        }

        public static void MaximoPermitido(string valor, int quatidadeLimite, string msgErro)
        {
            if (valor.Length > quatidadeLimite)
                throw new Exception(msgErro);
        }
    }
}
