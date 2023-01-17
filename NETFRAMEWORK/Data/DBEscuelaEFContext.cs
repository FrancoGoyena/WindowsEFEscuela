using NETFRAMEWORK.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETFRAMEWORK.Data
{
    public class DBEscuelaEFContext : DbContext
    {
        public DBEscuelaEFContext() : base("KeyDB") { }


        //Propiedades DBSET
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Aula> Aulas { get; set; }
    }
}
