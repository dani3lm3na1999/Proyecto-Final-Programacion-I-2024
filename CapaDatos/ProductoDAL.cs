using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ProductoDAL
    {

        // Crear una instancia privada de nuestro DbContext
        private TiendaDbContext _db;

        // Crear un método que nos ayude a crear y actualizar un producto
        public int Guardar(Producto producto, int id = 0, bool esActualizacion = false)
        {
            int resultado = 0;

            // Inicializamos nuestro contexto
            _db = new TiendaDbContext();

            if (esActualizacion) // Actualizar un producto
            {
                producto.ProductoId = id;

                _db.Entry(producto).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();

                resultado = producto.ProductoId;
            }
            else // Guardar un producto
            {
                _db.Productos.Add(producto);
                _db.SaveChanges();

                resultado = producto.ProductoId;
            }

            return resultado;
        }
    }
}
