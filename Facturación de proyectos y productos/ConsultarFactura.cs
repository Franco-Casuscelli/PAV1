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
    public partial class ConsultarFactura : Form
    {
        private DataTable dt;
        private String idFactura;
        private String idCliente;
        private String idResponsable;

        public ConsultarFactura()
        {
            InitializeComponent();

            
            txtDireccion.Enabled = false;
            txtCuit.Enabled = false;
            BoxCliente.Enabled = false;
            dataFecha.Enabled = false;
            dataGrid.Enabled = false;
            BoxResponsable.Enabled = false;
            BoxPrecio.Enabled = false;

            dt = new DataTable();
            dt.Columns.Add("Proyecto");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Version");
            dt.Columns.Add("Alcance");
            dt.Columns.Add("Precio");

            dataGrid.DataSource = dt;
            dataGrid.AllowUserToAddRows = false;

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlBarrio = "Select * From Facturas";
                SqlCommand command = new SqlCommand(consultaSqlBarrio, conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BoxNumFact.Items.Add(reader["numero_factura"].ToString());
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
        }

        private void ConsultarFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (BoxNumFact.Text == "")
            {
                MessageBox.Show("Por favor ingrese un numero de factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion.Open();

                    String consultaSqlBarrio = "Select * From Facturas where numero_factura = @numero";
                    SqlCommand command = new SqlCommand(consultaSqlBarrio, conexion);

                    command.Parameters.AddWithValue("@numero", BoxNumFact.Text);


                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        idFactura = reader["id_factura"].ToString();
                        idCliente = reader["id_cliente"].ToString();
                        idResponsable = reader["id_usuario_creador"].ToString();
                        dataFecha.Text = reader["fecha"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra el numero de factura ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        BoxNumFact.Text = "";
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

                //ya tenemos los datos ahora buscamos

                SqlConnection conexion2 = new SqlConnection();
                conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion2.Open();

                    String consultaSqlNombreRepetido = "Select * From Contactos where id_contacto = @Contacto";
                    SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion2);

                    command.Parameters.AddWithValue("@Contacto", idCliente);

                    SqlDataReader reader = command.ExecuteReader();

                    if(reader.Read())
                    {
                        BoxCliente.Text = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
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

                //------

                SqlConnection conexion3 = new SqlConnection();
                conexion3.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion3.Open();

                    String consultaSqlNombreRepetido = "Select * From Clientes where id_contacto = @Contacto";
                    SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion3);

                    command.Parameters.AddWithValue("@Contacto", idCliente);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txtDireccion.Text = reader["calle"].ToString() + " " + reader["numero"].ToString();
                        txtCuit.Text = reader["cuit"].ToString();
                    }
                    reader.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexion3.State == ConnectionState.Open)
                    {
                        conexion3.Close();
                    }
                }

                //------

                SqlConnection conexion4 = new SqlConnection();
                conexion4.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion4.Open();

                    String consultaSqlNombreRepetido = "Select * From Usuarios where id_usuario = @Responsable";
                    SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion4);

                    command.Parameters.AddWithValue("@Responsable", idResponsable);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {

                        BoxResponsable.Text = reader["usuario"].ToString();
                    }
                    reader.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexion4.State == ConnectionState.Open)
                    {
                        conexion4.Close();
                    }
                }




            }
        }
    }
}
