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
    public partial class ConsultarCliente : Form
    {
        private DataTable grilla;

        

        public ConsultarCliente()
        {
            InitializeComponent();

            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            BoxFilas.Enabled = false;

            grilla = new DataTable();
            grilla.Columns.Add("ID");
            grilla.Columns.Add("Cuit");
            grilla.Columns.Add("Razon social");
            grilla.Columns.Add("Contacto");
            grilla.Columns.Add("Calle");
            grilla.Columns.Add("Numero");
            grilla.Columns.Add("Barrio");

            grillaCliente.DataSource = grilla;
            grillaCliente.AllowUserToAddRows = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)

        {
            String idBarrio = "";
            String idContacto = "";   
            String nombreBarrio = "none";
            String email = "none";

            if (txtCuitConsulta.Text == "")
            {
                MessageBox.Show("Por favor ingrese un numero de cuit", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            else
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion.Open();

                    String consultaSql = "Select * From Clientes where cuit = @cuit ";
                    SqlCommand command = new SqlCommand(consultaSql, conexion);
                    command.Parameters.AddWithValue("@cuit", txtCuitConsulta.Text);
                    SqlDataReader reader = command.ExecuteReader();


                    if (reader.Read())
                    {
                        idBarrio = reader["id_barrio"].ToString();
                        idContacto = reader["id_contacto"].ToString();
                      
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
                
                SqlConnection conexion4 = new SqlConnection();
                conexion4.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";
                try
                {
                    conexion4.Open();
                    String consultaSqlContacto = "Select * From Barrios where id_barrio = '" + idBarrio + "'";
                    SqlCommand command = new SqlCommand(consultaSqlContacto, conexion4);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        nombreBarrio = reader["nombre"].ToString();
                        
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
                SqlConnection conexion5 = new SqlConnection();
                conexion5.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";
                try
                {
                    conexion5.Open();
                    String consultaSqlContacto = "Select * From Contactos where id_contacto = '" + idContacto + "'";
                    SqlCommand command = new SqlCommand(consultaSqlContacto, conexion5);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        email = reader["email"].ToString();
                        
                    }
                    reader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexion5.State == ConnectionState.Open)
                    {
                        conexion5.Close();
                    }
                }

                SqlConnection conexion6 = new SqlConnection();
                conexion6.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion6.Open();

                    String DatosProyecto = "Select * From Clientes where cuit = '" + this.txtCuitConsulta.Text + "'";
                    SqlCommand command2 = new SqlCommand(DatosProyecto, conexion6);

                    SqlDataReader reader1 = command2.ExecuteReader();

                    if (reader1.Read())
                    {
                        DataRow row = grilla.NewRow();

                        row["ID"] = reader1["id_cliente"].ToString();
                        row["Cuit"] = reader1["cuit"].ToString();
                        row["Razon Social"] = reader1["razon_social"].ToString();
                        row["Contacto"] = email;
                        row["Calle"] = reader1["calle"].ToString();
                        row["Numero"] = reader1["numero"].ToString();
                        row["Barrio"] = nombreBarrio;

                        grilla.Rows.Add(row);

                    }
                    reader1.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conexion6.State == ConnectionState.Open)
                    {
                        conexion6.Close();
                    }
                }
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grillaCliente.Rows.Count == 1)
            {
                MessageBox.Show("No se encuentra proyecto a modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else
            {
                String datoID = this.grillaCliente.CurrentCell.Value.ToString();

                Form formulario = new ModificarCliente(datoID);

                formulario.ShowDialog();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grillaCliente.Rows.Count == 1)
            {
                MessageBox.Show("No se encuentra proyecto a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else
            {

                String datoID = this.grillaCliente.CurrentCell.Value.ToString();


                if (MessageBox.Show("¿Esta seguro que desea Eliminar este proyecto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conexion = new SqlConnection();


                    conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";


                    try
                    {

                        conexion.Open();


                        String cambio = "UPDATE dbo.Clientes SET borrado = @Borrado WHERE id_cliente = @valor";

                        SqlCommand comando = new SqlCommand(cambio, conexion);

                        comando.Parameters.AddWithValue("@valor", datoID);
                        comando.Parameters.AddWithValue("@Borrado", 1);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Eliminado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }



                    catch (SqlException ex)
                    {

                        MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {

                        if (conexion.State == ConnectionState.Open)
                        {
                            //Cerramos la conexion
                            conexion.Close();
                        }
                    }



                }
            }
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void grillaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grillaCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
