using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Ubicacion_Pedido")]
    public class Ubicacion_PedidoModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DireccionId { get; set; }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string Referencia { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public virtual ClienteModel? Cliente { get; set; }
    }
}
