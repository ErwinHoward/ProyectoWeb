namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartDoctor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre_Doctor = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        No_Paciente = c.Int(nullable: false),
                        Nombre_Paciente = c.String(),
                        AM_Paciente = c.String(),
                        AP_Paciente = c.String(),
                        Fecha_Nacimiento_Paciente = c.DateTime(nullable: false),
                        Genero_Paciente = c.String(),
                        Numero_Paciente = c.Int(nullable: false),
                        Enfermedad_Paciente = c.String(),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pacientes", "DoctorId", "dbo.Doctors");
            DropIndex("dbo.Pacientes", new[] { "DoctorId" });
            DropTable("dbo.Pacientes");
            DropTable("dbo.Doctors");
        }
    }
}
