using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo
{
    [Table(name: "Marcas")]
    public class Marca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MarcaId { get; set; }
        [Column(name: "nombre_marca")]
        [Required]
        public string Nombre { get; set; }
        [Column(name: "descripcion_marca")]
        public string Descripcion { get; set; }

        // Llave foranea de Categoria
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
