namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartActividad11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Actividads", "ActividadId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Actividads", "ActividadId", c => c.Int(nullable: false));
        }
    }
}
