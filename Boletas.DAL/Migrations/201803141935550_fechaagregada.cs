namespace Boletas.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fechaagregada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Peliculas", "InicioCartelera", c => c.DateTime(nullable: false));
            AddColumn("dbo.Peliculas", "FinCartelera", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Peliculas", "FinCartelera");
            DropColumn("dbo.Peliculas", "InicioCartelera");
        }
    }
}
