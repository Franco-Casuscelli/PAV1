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
    public partial class ModificarContacto : Form
    {

        String ID;

        public ModificarContacto(String datoID)
        {
            InitializeComponent();
            BoxUsuarioLogueado.Text = Dato.UsuarioLogueado;
            ID = datoID;


            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();
                String consultaSql = string.Concat(" SELECT * ",
                                                   "   FROM Contactos ",
                                                   "  WHERE id_contacto = '" + this.ID + "'");

                SqlCommand command = new SqlCommand(consultaSql, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    BoxNombre.Text = reader["nombre"].ToString();
                    BoxApellido.Text = reader["apellido"].ToString();
                    BoxEmail.Text = reader["email"].ToString();
                    BoxTelefono.Text = reader["telefono"].ToString();

                }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if ((BoxNombre.Text == "") || (BoxApellido.Text == "") || (BoxEmail.Text == "") || (BoxTelefono.Text == ""))
            {
                MessageBox.Show("Por favor ingrese los campos solicitados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                SqlConnection conexion = new SqlConnection();

                conexion.ConnectionString = "Data Source=(localdb)\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";

                try
                {
                    conexion.Open();

                    String consultaSql = "UPDATE dbo.Contactos SET nombre = @Nombre,apellido = @Apellido,email = @Email,telefono = @Telefono WHERE id_contacto = '" + this.ID + "'";
                   
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    command.Parameters.AddWithValue("@Nombre", BoxNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", BoxApellido.Text);
                    command.Parameters.AddWithValue("@Email", BoxEmail.Text);
                    command.Parameters.AddWithValue("@Telefono", BoxTelefono.Text);

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

    }
}

