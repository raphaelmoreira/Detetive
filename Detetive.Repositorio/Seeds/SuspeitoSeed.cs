using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Detetive.Dominio.Entidades;

namespace Detetive.Repositorio.Seeds
{
    public class SuspeitoSeed
    {
        public static void Seed(EFContexto contexto)
        {
            contexto.Suspeitos.AddOrUpdate(x => x.Descricao, new Suspeito(1, "Esqueleto"));
            contexto.Suspeitos.AddOrUpdate(x => x.Descricao, new Suspeito(2, "Khan"));
            contexto.Suspeitos.AddOrUpdate(x => x.Descricao, new Suspeito(3, "Darth vader"));
            contexto.Suspeitos.AddOrUpdate(x => x.Descricao, new Suspeito(4, "Sideshow Bob"));
            contexto.Suspeitos.AddOrUpdate(x => x.Descricao, new Suspeito(5, "Coringa"));
            contexto.Suspeitos.AddOrUpdate(x => x.Descricao, new Suspeito(6, "Duende Verde"));
        }
    }
}
