using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Productos")]
    public class ProductosModel
    {
        [Key]
        public int ProductoId { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(200)]
        public string Descripcion { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Precio { get; set; }
        public int CategoriaId { get; set; }
        public int PreparacionId { get; set; }
        [ForeignKey("CategoriaId")]
        public virtual CategoriaModel? Categorias { get; set; }
        [ForeignKey("PreparacionId")]
        public virtual PreparacionModel? Preparacion { get; set; }
    }
}
