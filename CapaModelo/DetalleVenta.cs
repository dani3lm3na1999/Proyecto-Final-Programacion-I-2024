using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public class DetalleVenta
    {
        public int DetalleVentaId { get; set; }

        // Relacion con la Venta
        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        // Relacion con el Producto
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal { get; set; } // Cantidad * PrecioUnitario

    }
}
