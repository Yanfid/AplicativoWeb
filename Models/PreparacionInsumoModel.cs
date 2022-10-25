using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("PreparacionInsumo")]
    public class PreparacionInsumoModel
    {
        [Key]
          public int PreparacioninsumoId { get; set; }
        public int Cantidad { get; set; }
        public int InsumoId { get; set; }
        [ForeignKey("InsumoId")]
        public virtual InsumosModel? Insumos { get; set; }
    }
}
