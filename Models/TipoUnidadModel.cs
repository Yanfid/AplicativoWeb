using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Table("TipoUnidad")]
    public class TipoUnidadModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UnidadId { get; set; }
        [MaxLength(65)]
        public string NombreUnidad { get; set; }
    }
}
