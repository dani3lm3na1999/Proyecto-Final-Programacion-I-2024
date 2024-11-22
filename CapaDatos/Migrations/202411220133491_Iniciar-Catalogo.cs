namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IniciarCatalogo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false, identity: true),
                        nombre_categoria = c.String(nullable: false),
                        descripcion_categoria = c.String(),
                    })
                .PrimaryKey(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        nombres_cliente = c.String(nullable: false),
                        apellidos_cliente = c.String(nullable: false),
                        documento_cliente = c.String(),
                        direccion_cliente = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.DetalleVentas",
                c => new
                    {
                        DetalleVentaId = c.Int(nullable: false, identity: true),
                        VentaId = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                        cantidad_detalle = c.Int(nullable: false),
                        precio_unitario_detalle = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DetalleVentaId)
                .ForeignKey("dbo.Productos", t => t.ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Ventas", t => t.VentaId, cascadeDelete: true)
                .Index(t => t.VentaId)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        nombre_producto = c.String(nullable: false),
                        descripcion_producto = c.String(nullable: false),
                        precio_producto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        existencias_producto = c.Int(nullable: false),
                        proveedor_producto = c.Int(nullable: false),
                        MarcaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId)
                .ForeignKey("dbo.Marcas", t => t.MarcaId, cascadeDelete: true)
                .Index(t => t.MarcaId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        MarcaId = c.Int(nullable: false, identity: true),
                        nombre_marca = c.String(nullable: false),
                        descripcion_marca = c.String(),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MarcaId)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .Index(t => t.CategoriaId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        fecha_venta = c.DateTime(nullable: false),
                        vendedor_venta = c.Int(nullable: false),
                        total_venta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VentaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DetalleVentas", "VentaId", "dbo.Ventas");
            DropForeignKey("dbo.Ventas", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.DetalleVentas", "ProductoId", "dbo.Productos");
            DropForeignKey("dbo.Productos", "MarcaId", "dbo.Marcas");
            DropForeignKey("dbo.Marcas", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Ventas", new[] { "ClienteId" });
            DropIndex("dbo.Marcas", new[] { "CategoriaId" });
            DropIndex("dbo.Productos", new[] { "MarcaId" });
            DropIndex("dbo.DetalleVentas", new[] { "ProductoId" });
            DropIndex("dbo.DetalleVentas", new[] { "VentaId" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Marcas");
            DropTable("dbo.Productos");
            DropTable("dbo.DetalleVentas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}
