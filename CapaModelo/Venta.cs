using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    [Table(name: "Ventas")]
    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VentaId { get; set; }
        [Column(name: "fecha_venta")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Column(name: "vendedor_venta")]
        [Required]
        public Vendedores Vendedor { get; set; }
        [Column(name: "total_venta")]
        [Required]
        public decimal Total { get; set; }

        // relacionar el Cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
