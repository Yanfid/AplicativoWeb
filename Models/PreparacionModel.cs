using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Preparacion")]
    public class PreparacionModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PreparacionId { get; set; }
        public int InsumoId { get; set; }
        [ForeignKey("InsumoId")]
        public virtual PreparacionInsumoModel? PreparacionInsumo { get; set; }
    }
}
