using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturación_de_proyectos_y_productos
{
    public partial class FormPrincipal : Form
    {
       
        public FormPrincipal()
        {
            InitializeComponent();
            BoxUsuarioLogueado.Enabled = false;

        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n    Version 1.0.0 \n    Copyright ©2020\n\n","Acerca de...");
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formulario = new CrearBarrio();
            formulario.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultarBarrio();
            formulario.ShowDialog();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Login login = new Login();
            login.ShowDialog();
            BoxUsuarioLogueado.Text = Dato.UsuarioLogueado;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void crearToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form formulario = new CrearProyecto();
            formulario.ShowDialog();
        }

        private void consultarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultarProyectos();
            formulario.ShowDialog();
        }

        private void crearToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form formulario = new CrearFacturas();
            formulario.ShowDialog();
        }

        private void crearToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form formulario = new frmCrearCliente();
            formulario.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultarCliente();
            formulario.ShowDialog();
        }

        private void consultarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultarFactura();
            formulario.ShowDialog();
        }

        private void crearToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form formulario = new CrearContacto();
            formulario.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form formulario = new ConsultarContactos();
            formulario.ShowDialog();
        }
    }
}
