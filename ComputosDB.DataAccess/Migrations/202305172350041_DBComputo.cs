namespace ComputosDB.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBComputo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computadoras",
                c => new
                    {
                        idComputadora = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.idComputadora);
            
            CreateTable(
                "dbo.Detallecomputadoras",
                c => new
                    {
                        IdDetallecomputadora = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 80),
                        Ram = c.String(nullable: false),
                        ModeloDePlaca = c.String(nullable: false),
                        Teclado = c.String(nullable: false),
                        Raton = c.String(nullable: false),
                        Procesador = c.String(nullable: false),
                        NumerodeRAM = c.Int(nullable: false),
                        Nucleos = c.String(nullable: false),
                        PulgadasDepantalla = c.Decimal(nullable: false, precision: 18, scale: 2),
                        idComputadora = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetallecomputadora)
                .ForeignKey("dbo.Computadoras", t => t.idComputadora)
                .Index(t => t.idComputadora);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Detallecomputadoras", "idComputadora", "dbo.Computadoras");
            DropIndex("dbo.Detallecomputadoras", new[] { "idComputadora" });
            DropTable("dbo.Detallecomputadoras");
            DropTable("dbo.Computadoras");
        }
    }
}
