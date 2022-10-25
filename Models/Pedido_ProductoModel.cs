using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Pedido_Producto")]
    public class Pedido_ProductoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pedido_ProductoId { get; set; }
        public int Cantidad { get; set; }
        public int ProductoId { get; set; }
        [ForeignKey("ProductoId")]
        public virtual ProductosModel? Productos { get; set; }
    }
}
