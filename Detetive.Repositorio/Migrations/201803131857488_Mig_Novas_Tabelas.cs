namespace Detetive.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig_Novas_Tabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Local",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Suspeito",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Suspeito");
            DropTable("dbo.Local");
        }
    }
}
