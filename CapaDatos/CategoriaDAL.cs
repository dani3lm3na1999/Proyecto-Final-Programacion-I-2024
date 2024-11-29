using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CategoriaDAL
    {
        private TiendaDbContext _db;

        // Método para mostrar las categorias
        public List<Categoria> ObtenerTodo()
        {
            _db = new TiendaDbContext();

            return _db.Categorias.ToList();
        }
    }
}
