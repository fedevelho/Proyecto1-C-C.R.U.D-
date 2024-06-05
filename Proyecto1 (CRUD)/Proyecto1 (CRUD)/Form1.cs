using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1__CRUD_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.Alumnos objetoAlumnos = new Clases.Alumnos();
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Clases.Alumnos objetoAlumnos = new Clases.Alumnos();
            objetoAlumnos.guardarAlumnos(txtNombres, txtApellidos);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);


        }

        private void dgvTotalAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Alumnos objetoAlumnos = new Clases.Alumnos();
            objetoAlumnos.seleccionarAlumnos(dgvTotalAlumnos, txtId, txtNombres, txtApellidos);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.Alumnos objetoAlumnos = new Clases.Alumnos();
            objetoAlumnos.modificarAlumnos(txtId, txtNombres, txtApellidos);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clases.Alumnos objetoAlumnos = new Clases.Alumnos();
            objetoAlumnos.EliminarAlumnos(txtId);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }
    }
}
