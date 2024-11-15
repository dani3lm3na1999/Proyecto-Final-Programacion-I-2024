using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public enum Vendedores
    {
        Juan_Perez = 1,
        Maria_Lopez = 2,
        Lucia_Cruz = 3
    }

    public enum Sucursales
    {
        Chalatenango = 1,
        San_Salvador = 2,
        San_Miguel = 3
    }

    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public Vendedores Vendedor { get; set; }
        public decimal Total { get; set; }

        // relacionar el Cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
