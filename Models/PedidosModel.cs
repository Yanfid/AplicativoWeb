using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Pedidos")]
    public class PedidosModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PedidoId { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        [Column(TypeName = "decimal(8,2)")]
        public decimal Total { get; set; }
        public int EmpleadoId { get; set; }
        public int Pedido_ProductoId { get; set; }
        public int EstadoId { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual EmpleadoModel? Empleado { get; set; }
        [ForeignKey("Pedido_ProductoId")]
        public virtual Pedido_ProductoModel? Pedido_Producto { get; set; }
        [ForeignKey("EstadoId")]
        public virtual EstadoModel? Estado { get; set; }
        [ForeignKey("ClienteId")]
        public virtual ClienteModel? Cliente { get; set; }
    }
}
