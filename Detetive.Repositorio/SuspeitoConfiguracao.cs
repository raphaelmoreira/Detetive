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
    public class SuspeitoConfiguracao : EntityTypeConfiguration<Suspeito>
    {
        public SuspeitoConfiguracao()
        {
            Property(x => x.Descricao)
                .HasMaxLength(Suspeito.DescricaoMaximoPermitido)
                .IsRequired()
                .HasColumnName("Descricao");
        }
    }
}
