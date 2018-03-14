namespace Boletas.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class limpieza : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Peliculas", "Descuento");
            DropColumn("dbo.Peliculas", "TotalCobrado");
            DropColumn("dbo.Peliculas", "Promocion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Peliculas", "Promocion", c => c.String(maxLength: 150));
            AddColumn("dbo.Peliculas", "TotalCobrado", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Peliculas", "Descuento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
