namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartAdmin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administradors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Id_Usuario = c.String(),
                        Nombre = c.String(),
                        APM = c.String(),
                        APP = c.String(),
                        TrabajadorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trabajadors", t => t.TrabajadorId, cascadeDelete: true)
                .Index(t => t.TrabajadorId);
            
            CreateTable(
                "dbo.Trabajadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Administradors", "TrabajadorId", "dbo.Trabajadors");
            DropIndex("dbo.Administradors", new[] { "TrabajadorId" });
            DropTable("dbo.Trabajadors");
            DropTable("dbo.Administradors");
        }
    }
}
