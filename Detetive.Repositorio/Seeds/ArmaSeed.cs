using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Detetive.Dominio.Entidades;

namespace Detetive.Repositorio.Seeds
{
    public class ArmaSeed
    {
        public static void Seed(EFContexto contexto)
        {
            contexto.Armas.AddOrUpdate(x => x.Descricao, new Arma(1, "Cajado Devastador"));
            contexto.Armas.AddOrUpdate(x => x.Descricao, new Arma(2, "Phaser"));
            contexto.Armas.AddOrUpdate(x => x.Descricao, new Arma(3, "Peixeira"));
            contexto.Armas.AddOrUpdate(x => x.Descricao, new Arma(4, "Trezoitão"));
            contexto.Armas.AddOrUpdate(x => x.Descricao, new Arma(5, "Sabre de Luz"));
            contexto.Armas.AddOrUpdate(x => x.Descricao, new Arma(6, "Bomba"));
        }
    }
}
