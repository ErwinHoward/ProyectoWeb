namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartHospital1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hospitals", "Numero_Hospital", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hospitals", "Numero_Hospital", c => c.Int(nullable: false));
        }
    }
}
