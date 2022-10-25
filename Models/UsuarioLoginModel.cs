using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UsuarioLoginModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public int EmpleadoId { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual EmpleadoModel? Empleado { get; set; }
    }
}
