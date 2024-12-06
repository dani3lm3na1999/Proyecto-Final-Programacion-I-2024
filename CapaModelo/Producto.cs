using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    public enum Proveedores
    {
        Jose_Iraheta = 1,
        Marco_Solis = 2,
        Karla_Mejia = 3
    }
    [Table(name: "Productos")]
    public class Producto
    {
        // Campos de mi clase
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductoId { get; set; }
        [Column(name: "nombre_producto")]
        [Required]
        public string Nombre { get; set; }
        [Column(name: "descripcion_producto")]
        [Required]
        public string Descripcion { get; set; }
        [Column(name: "precio_producto")]
        [Required]
        public decimal Precio { get; set; }
        [Column(name: "existencias_producto")]
        [Required]
        public int Existencias { get; set; }
        [Column(name: "proveedor_producto")]
        [Required]
        public Proveedores Proveedor { get; set; }
        
        // Llave foranea de Marca
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
    }
}
