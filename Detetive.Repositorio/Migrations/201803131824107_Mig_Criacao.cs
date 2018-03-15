namespace Detetive.Repositorio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig_Criacao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arma",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Arma");
        }
    }
}
