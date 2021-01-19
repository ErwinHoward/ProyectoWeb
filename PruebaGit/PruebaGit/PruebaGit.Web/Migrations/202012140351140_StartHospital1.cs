namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StartHospital1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Rol", c => c.String());

            AlterColumn("dbo.Hospitals", "Numero_Hospital", c => c.Int(nullable: false));

        }
        
        public override void Down()
        {

            DropColumn("dbo.AspNetUsers", "Rol");

            AlterColumn("dbo.Hospitals", "Numero_Hospital", c => c.String(nullable: false));

        }
    }
}
