using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Adquisiciones")]
    public class AdquisicionesModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdquisicionesId { get; set; }
        public int InsumoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAdquisicion { get; set; }
        public DateTime FechaCaducidad { get; set; }
        [ForeignKey("InsumoId")]
        public virtual InsumosModel? Insumos { get; set; }
    }
}
