using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using Detetive.Dominio.Entidades;

namespace Detetive.Repositorio.Seeds
{
    public class LocalSeed
    {
        public static void Seed(EFContexto contexto)
        {
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(1, "Etérnia"));
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(2, "Vulcano"));
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(3, "Tatooine"));
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(4, "Springfield"));
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(5, "Gotham"));
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(6, "Nova York"));
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(7, "Sibéria"));
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(8, "Machu Picchu"));
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(9, "Show do Katinguele"));
            contexto.Locais.AddOrUpdate(x => x.Descricao, new Local(10, "São Paulo"));
        }
    }
}
