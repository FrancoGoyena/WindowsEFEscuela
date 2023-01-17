using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETFRAMEWORK.Models
{
    [Table("Docente")]
    public class Profesor
    {
        [Column("Id")]
        public int ProfesorId { get; set; }
        [Column(TypeName = "varchar")]//Tipo de datos en SQL Server
        [StringLength(50)]//Long de la cadena
        [Required]//Es obligatorio. No acepta nulos
        public string Nombre { get; set; }
        [Column(TypeName = "varchar")]//Tipo de datos en SQL Server
        [StringLength(50)]//Long de la cadena
        [Required]//Es obligatorio. No acepta nulos
        public string Apellido { get; set; }

        [Column(TypeName = "varchar")]//Tipo de datos en SQL Server
        [StringLength(50)]//Long de la cadena
        [Required]//Es obligatorio. No acepta nulos

        public string Titulo { get; set; }

        public List<Alumno> Alumnos { get; set; }

    }
}
