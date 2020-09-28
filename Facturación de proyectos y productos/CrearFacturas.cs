using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturación_de_proyectos_y_productos
{
    public partial class CrearFacturas : Form
    {
        public CrearFacturas()
        {
            InitializeComponent();
            txtNumeroFactura.Enabled = false;
            txtDireccion.Enabled = false;
            txtCuit.Enabled = false;
            BtnEliminar.Enabled = false;
            btnGuardar.Enabled = false;

            BoxTipoFact.Items.Add("A");
            BoxTipoFact.Items.Add("B");
            BoxTipoFact.Items.Add("C");

            String Cont = "0";
            String Formato = "2020-0000";


            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlNombreRepetido = "Select * From Proyectos";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BoxProducto.Items.Add(reader["id_proyecto"].ToString());
                }
                reader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            //--------------------------------------------------------------------------

            SqlConnection conexion2 = new SqlConnection();
            conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion2.Open();

                String consultaSqlNombreRepetido = "Select * From Facturas";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion2);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cont = Cont + 1;
                }
                reader.Close();

            }

            catch (SqlException ex)
            {
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion2.State == ConnectionState.Open)
                {
                    conexion2.Close();
                }
            }
            Cont = Cont + 1;
            txtNumeroFactura.Text = (Formato + Cont);







        }

        private void CrearFacturas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir del formulario?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
