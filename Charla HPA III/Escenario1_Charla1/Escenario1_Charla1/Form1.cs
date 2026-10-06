using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Escenario1_Charla1
{
    public partial class Form1 : Form
    {
        private List<Estudiante> listaEstudiantes = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCedula.MaxLength = 10;
            txtNombre.MaxLength = 30;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
        }

        private void lblCedula_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Estudiante nuevoEstudiante = new Estudiante();
            nuevoEstudiante.Cedula = txtCedula.Text;
            nuevoEstudiante.Nombre = txtNombre.Text;

            listaEstudiantes.Add(nuevoEstudiante);

            dgvEstudiantes.AutoGenerateColumns = true;
            dgvEstudiantes.DataSource = null;
            dgvEstudiantes.DataSource = listaEstudiantes;

            txtCedula.Clear();
            txtNombre.Clear();
            txtCedula.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Estudiante
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
    }
}