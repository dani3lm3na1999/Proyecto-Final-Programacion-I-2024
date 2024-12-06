using CapaDatos;
using CapaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class MarcaBLL
    {
        private MarcaDAL _marcaDAL;

        public List<Marca> ObtenerPorCategoria(int categoriaId)
        {
            _marcaDAL = new MarcaDAL();

            return _marcaDAL.ObtenerPorCategoria(categoriaId);
        } 
    }
}
