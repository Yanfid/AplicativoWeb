using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("Insumos")]
    public class InsumosModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InsumoId { get; set; }
        [MaxLength(100)]
        public string Descripcion { get; set; }
        public int UnidadId { get; set; }
        [ForeignKey("UnidadId")]
        public virtual TipoUnidadModel? TipoUnidad { get; set; }   
    }
}   
