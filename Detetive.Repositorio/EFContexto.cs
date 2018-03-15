using Detetive.Dominio;
using Detetive.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Detetive.Repositorio
{
    public class EFContexto : DbContext
    {
        public EFContexto() : base("EFContexto")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Arma> Armas { get; set; }
        public DbSet<Local> Locais { get; set; }
        public DbSet<Suspeito> Suspeitos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(c => c.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(4000));

            modelBuilder.Configurations.Add(new ArmaConfiguracao());
            modelBuilder.Configurations.Add(new LocalConfiguracao());
            modelBuilder.Configurations.Add(new SuspeitoConfiguracao());
        }
    }
}
