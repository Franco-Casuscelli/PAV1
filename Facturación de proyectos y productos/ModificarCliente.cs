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
    public partial class ModificarCliente : Form

    {
        String ID;
        public ModificarCliente(String datoID)
        {
            InitializeComponent();

            BoxUsuarioLogueado.Text = Dato.UsuarioLogueado;

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlBarrio = "Select * From Barrios";
                SqlCommand command = new SqlCommand(consultaSqlBarrio, conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbBarrio.Items.Add(reader["nombre"].ToString());
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
            SqlConnection conexion2 = new SqlConnection();
            conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion2.Open();

                String consultaSqlContacto = "Select * From Contactos";
                SqlCommand command = new SqlCommand(consultaSqlContacto, conexion2);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbContacto.Items.Add(reader["nombre"].ToString());
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

            ID = datoID;

            SqlConnection conexion1 = new SqlConnection();
            conexion1.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion1.Open();

                String consultaSql= "Select * From Clientes where id_cliente = @valor";
                SqlCommand command = new SqlCommand(consultaSql, conexion1);

                command.Parameters.AddWithValue("@valor", ID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtRazonSocial1.Text = reader["razon_social"].ToString();
                    txtCuit1.Text = reader["cuit"].ToString();
                    txtCalle.Text = reader["calle"].ToString();
                    txtNumero.Text = reader["numero"].ToString();
                }
                reader.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion1.State == ConnectionState.Open)
                {
                    conexion1.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String idBarrio = "none";
            String idContacto = "none";

            if ((txtRazonSocial1.Text == "" || txtNumero.Text == "" || txtCalle.Text == "" || txtCuit1.Text == "" || cmbBarrio.Text == "" || cmbContacto.Text == ""))
            {
                MessageBox.Show("No se admineten campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source=(localdb)\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";
                try
                {
                    conexion.Open();

                    String consultaSqlBarrio1 = "Select * From Barrios where nombre = '" + this.cmbBarrio.Text + "'";
                    SqlCommand command = new SqlCommand(consultaSqlBarrio1, conexion);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        idBarrio = reader["id_barrio"].ToString();
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
                SqlConnection conexion2 = new SqlConnection();
                conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion2.Open();

                    String consultaSqlContacto = "Select * From Contactos where nombre = '" + this.cmbContacto.Text + "'";
                    SqlCommand command = new SqlCommand(consultaSqlContacto, conexion2);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
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
                    if (conexion2.State == ConnectionState.Open)
                    {
                        conexion2.Close();
                    }
                }
                try
                {
                    SqlConnection conexion3 = new SqlConnection();
                    conexion3.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True"; 

                    conexion3.Open();

                    String consultaSql = "UPDATE dbo.Clientes SET razon_social = @razon_social, cuit = @cuit, calle = @calle , numero = @numero , id_barrio = @id_barrio, id_contacto = @id_contacto WHERE id_cliente = '" + this.ID + "'";

                    
                    SqlCommand command = new SqlCommand(consultaSql, conexion3);

                    command.Parameters.AddWithValue("@razon_social", txtRazonSocial1.Text);
                    command.Parameters.AddWithValue("@cuit", txtCuit1.Text);
                    command.Parameters.AddWithValue("@calle", txtCalle.Text);
                    command.Parameters.AddWithValue("@numero", txtNumero.Text);
                    command.Parameters.AddWithValue("@id_barrio", idBarrio);
                    command.Parameters.AddWithValue("@id_contacto", idContacto);


                    try
                    {
                        command.ExecuteNonQuery();

                        MessageBox.Show("Modificado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
                catch (SqlException ex)
                {
                    //Mostramos un mensaje de error indicando que hubo un error en la base de datos.
                    MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //Preguntamos si el estado de la conexion es abierto antes de cerrar la conexion.
                    if (conexion.State == ConnectionState.Open)
                    {
                        //Cerramos la conexion
                        conexion.Close();
                    }
                }

                this.Close();
            }
        }

        private void ModificarCliente_Load(object sender, EventArgs e)
        {

        }

        private void BoxUsuarioLogueado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
