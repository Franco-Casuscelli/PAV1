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

        private DataTable dt;
        private int Cont;

        public CrearFacturas()
        {

            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Proyecto");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Version");
            dt.Columns.Add("Alcance");
            dt.Columns.Add("Precio");

            dataGrid.DataSource = dt;
            dataGrid.AllowUserToAddRows = false;      

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            BtnEliminar.Enabled = true;
            btnGuardar.Enabled = true;

            if ((BoxProducto.Text == "") || (BoxPrecioProducto.Text == ""))
            {
                MessageBox.Show("Por favor ingrese un Proyecto y/o Precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion.Open();

                    String consultaSqlNombreRepetido = "Select * From Proyectos where id_proyecto = '" + this.BoxProducto.Text + "'";
                    SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);            

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        DataRow row = dt.NewRow();

                        row["Proyecto"] = reader["id_proyecto"].ToString();
                        row["Descripcion"] = reader["descripcion"].ToString();
                        row["Version"] = reader["version"].ToString();
                        row["Alcance"] = reader["alcance"].ToString();
                        row["Precio"] = BoxPrecioProducto.Text;

                        dt.Rows.Add(row);

                        int temporal = Int16.Parse(BoxPrecioProducto.Text);
                        Cont = Cont + temporal;
                        BoxPrecio.Text = Cont.ToString();

                        BoxProducto.Text = "";
                        BoxPrecioProducto.Text = "";

                    }
                    reader.Close();

                    //dataGridView.Rows.Add(reader.Read());
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
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            String precioDescontar = this.dataGrid.CurrentRow.Cells[4].Value.ToString();

            int temporal = Int16.Parse(precioDescontar);
            Cont = Cont - temporal;
            BoxPrecio.Text = Cont.ToString();

            dataGrid.Rows.Remove(this.dataGrid.CurrentRow);

            String Filas = this.dataGrid.Rows.Count.ToString();
            int FilasINT = Int16.Parse(Filas);

            if(FilasINT == 0)
            {
                BtnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
            }
          
        }
    }
}
