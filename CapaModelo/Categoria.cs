using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    [Table(name: "Categorias")]
    public class Categoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoriaId { get; set; }
        [Column(name: "nombre_categoria")]
        [Required]
        public string Nombre { get; set; }
        [Column(name: "descripcion_categoria")]
        public string Descripcion { get; set; }
    }
}
