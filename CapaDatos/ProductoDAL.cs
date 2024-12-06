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


        public void Eliminar(int productoId)
        {
            _db = new TiendaDbContext();

            Producto producto = _db.Productos.Find(productoId);

            if (producto != null)
            {
                _db.Productos.Remove(producto);
                _db.SaveChanges();
            }            
        }

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

        // Método para obtener el listado de productos
        public List<Producto> ObtenerTodo()
        {
            _db = new TiendaDbContext();

            return _db.Productos.ToList();
        }
    }
}
