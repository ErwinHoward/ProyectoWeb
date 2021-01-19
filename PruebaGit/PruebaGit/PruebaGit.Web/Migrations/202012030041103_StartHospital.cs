namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartHospital : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero_Hospital = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Registrar_Hospital",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomHospital = c.Int(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 50),
                        Ciudad = c.String(nullable: false, maxLength: 50),
                        Colonia = c.String(nullable: false, maxLength: 50),
                        Calle = c.String(nullable: false, maxLength: 50),
                        Codigo_Postal = c.Int(nullable: false),
                        HospitalId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hospitals", t => t.HospitalId, cascadeDelete: true)
                .Index(t => t.HospitalId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registrar_Hospital", "HospitalId", "dbo.Hospitals");
            DropIndex("dbo.Registrar_Hospital", new[] { "HospitalId" });
            DropTable("dbo.Registrar_Hospital");
            DropTable("dbo.Hospitals");
        }
    }
}
