using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CategoriaBLL
    {
        private CategoriaDAL _categoriaDAL;

        public List<Categoria> ObtenerTodo()
        {
            _categoriaDAL = new CategoriaDAL();
            return _categoriaDAL.ObtenerTodo();
        }
    }
}
