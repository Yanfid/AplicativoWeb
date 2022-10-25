using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("TipoComprobante")]
    public class TipoComprobanteModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoComprobanteId { get; set; }
        public string TipoComprobante { get; set; }
        public int NumeroComprobante { get; set; }
    }
}
