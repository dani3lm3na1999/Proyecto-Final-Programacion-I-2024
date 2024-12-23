﻿using CapaModelo;
using System;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos
{
    public class TiendaDbContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'TiendaDbContext' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CapaDatos.TiendaDbContext' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'TiendaDbContext'  en el archivo de configuración de la aplicación.
        public TiendaDbContext()
            : base("name=TiendaDbContext")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Categoria> Categorias { get; set; }
    }
}