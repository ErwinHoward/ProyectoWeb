namespace PruebaGit.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hola : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.AspNetUsers", "Musics");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Musics", c => c.String());
        }
    }
}
