using NETFRAMEWORK.Dac;
using NETFRAMEWORK.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NETFRAMEWORK
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            MostrarAlumnos();
        }

        private void MostrarAlumnos()
        {
            gridalumno.DataSource = AbmAlumno.SelectAll();
        }

        private void gridalumno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttoninsertar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { Nombre = txtnombre.Text, Apellido=txtapellido.Text,FechaNacimiento= Convert.ToDateTime(txtfdn.Text) };

            int filasAfectadas = AbmAlumno.Insert(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
                MostrarAlumnos();
            }
        }

        private void buttonmodificar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { IdAlumno= Convert.ToInt32(txtid.Text),Nombre = txtnombre.Text, Apellido = txtapellido.Text, FechaNacimiento = Convert.ToDateTime(txtfdn.Text) };

            int filasAfectadas = AbmAlumno.Update(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostrarAlumnos();
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno() { IdAlumno = Convert.ToInt32(txtid.Text), Nombre = txtnombre.Text, Apellido = txtapellido.Text, FechaNacimiento = Convert.ToDateTime(txtfdn.Text) };

            int filasAfectadas = AbmAlumno.Delete(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarAlumnos();
            }
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);

            Alumno alumno = AbmAlumno.SelectWhereById(id);
            MessageBox.Show("Nombre: "+alumno.Nombre+"\nApellido: "+alumno.Apellido+ "\nFecha de nacimiento: " + alumno.FechaNacimiento);
        }
    }
}
