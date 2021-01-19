namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartActividad1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actividads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActividadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AgregarActividads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ID_Paciente = c.Int(nullable: false),
                        ID_Empleado = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Hora = c.Int(nullable: false),
                        Actividad_Realizar = c.String(nullable: false, maxLength: 300),
                        ActividadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Actividads", t => t.ActividadId, cascadeDelete: true)
                .Index(t => t.ActividadId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AgregarActividads", "ActividadId", "dbo.Actividads");
            DropIndex("dbo.AgregarActividads", new[] { "ActividadId" });
            DropTable("dbo.AgregarActividads");
            DropTable("dbo.Actividads");
        }
    }
}
