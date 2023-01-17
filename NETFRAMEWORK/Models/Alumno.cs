using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFRAMEWORK.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }
        [Column(TypeName = "varchar")]//Tipo de datos en SQL Server
        [StringLength(50)]//Long de la cadena
        [Required]//Es obligatorio. No acepta nulos
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]//Tipo de datos en SQL Server
        [StringLength(50)]//Long de la cadena
        [Required]//Es obligatorio. No acepta nulos
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        //public int ProfesorId { get; set; }
        //[ForeignKey("ProfesorId")]
        public Profesor Profesor { get; set; }
    }
}
