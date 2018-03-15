using Detetive.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Repositorio.Tests
{
    public class ArmaRepositorioTestsDados
    {
        public static List<Arma> Adquirir()
        {
            return new List<Arma>
            {
                new Arma(1, "blabla") { Id = 1 },
                new Arma(2, "blabla2") { Id = 2 },
                new Arma(3, "blabla3") { Id = 3 }
            };
        }
    }
}
