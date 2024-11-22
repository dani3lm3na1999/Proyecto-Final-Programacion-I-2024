using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class ProductoBLL
    {
        // Crear una instancia a mi clase ProductoDAL privada
        private ProductoDAL _productoDAL;

        // Nuestro método para guardar y actualizar desde nuestra capa BLL
        public int Guardar(Producto producto, int id = 0, bool esActuaizacion = false)
        {
            // Inicializar nuestro ProductoDAL
            _productoDAL = new ProductoDAL();

            // Retornar el valor
            return _productoDAL.Guardar(producto, id, esActuaizacion);
        }
    }
}
