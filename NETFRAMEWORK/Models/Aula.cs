using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETFRAMEWORK.Models
{
    [Table("Aula")]
    public class Aula
    {
        public int Id { get; set; }
        [Required]
        public int Capacidad { get; set; }
        [Column(TypeName = "char")]//Tipo de datos en SQL Server
        [StringLength(1)]//Long de la cadena
        [Required]
        public string Codigo { get; set; }


    }
}
