using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class MarcaDAL
    {
        private TiendaDbContext _db;

        public List<Marca> ObtenerPorCategoria(int categoriaId)
        {
            _db = new TiendaDbContext();

            return _db.Marcas.Where(marca => marca.CategoriaId == categoriaId).ToList();
        }
    }
}
