using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public enum Proveedores
    {
        Jose_Iraheta = 1,
        Marcoles_Solis = 2,
        Karla_Mejia = 3
    }

    public class Producto
    {
        // Campos de mi clase Producto
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencias { get; set; }
        public Proveedores Proveedor { get; set; }

        // Llave foranea de Categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

        // Llave foranea de Marca
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
    }
}
