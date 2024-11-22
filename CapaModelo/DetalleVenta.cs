using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    [Table(name: "DetalleVentas")]
    public class DetalleVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetalleVentaId { get; set; }

        // Relacion con la Venta
        public int VentaId { get; set; }
        public Venta Venta { get; set; }

        // Relacion con el Producto
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }

        [Column(name: "cantidad_detalle")]
        [Required]
        public int Cantidad { get; set; }
        [Column(name: "precio_unitario_detalle")]
        public decimal PrecioUnitario { get; set; }
        [NotMapped]
        public decimal SubTotal { get; set; } // Cantidad * PrecioUnitario

    }
}
