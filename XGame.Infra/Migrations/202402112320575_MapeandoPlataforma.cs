namespace XGame.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MapeandoPlataforma : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Plataforma",
                c => new
                    {
                        id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Plataforma");
        }
    }
}
