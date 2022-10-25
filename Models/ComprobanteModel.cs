using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Comprobante")]
    public class ComprobanteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ComprobanteId { get; set; }
        public string Descripcion { get; set; }
        public int Codigo { get; set; }
        public int PedidoId { get; set; }
        public int TipoComprobanteId { get; set; }
        [ForeignKey("PedidoId")]
        public virtual PedidosModel? Pedidos { get; set; }
        [ForeignKey("PedidoId")]
        public virtual TipoComprobanteModel? TipoComprobante { get; set; }
    }
}
