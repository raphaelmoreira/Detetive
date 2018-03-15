namespace Detetive.Repositorio.Migrations
{
    using Detetive.Repositorio.Seeds;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Detetive.Repositorio.EFContexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Detetive.Repositorio.EFContexto context)
        {
            ArmaSeed.Seed(context);
            LocalSeed.Seed(context);
            SuspeitoSeed.Seed(context);
        }
    }
}
