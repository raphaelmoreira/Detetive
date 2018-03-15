using Detetive.Dominio;
using Detetive.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Repositorio
{
    public class ArmaConfiguracao : EntityTypeConfiguration<Arma>
    {
        public ArmaConfiguracao()
        {
            Property(x => x.Descricao)
                .HasMaxLength(Arma.DescricaoMaximoPermitido)
                .IsRequired()
                .HasColumnName("Descricao");
        }
    }
}
