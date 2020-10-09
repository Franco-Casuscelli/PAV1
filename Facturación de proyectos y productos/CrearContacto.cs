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
    public partial class CrearContacto : Form
    {
        public CrearContacto()
        {
            InitializeComponent();
            BoxUsuarioLogueado.Text = Dato.UsuarioLogueado;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if ((BoxNombre.Text == "") || (BoxApellido.Text == "") || (BoxEmail.Text == "") || (BoxTelefono.Text == "") ) 
            {
                MessageBox.Show("Por favor ingrese los campos solicitados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion.Open();

                    String consultaSqlNombreRepetido = "INSERT INTO dbo.Contactos(nombre,apellido,email,telefono,borrado) VALUES(@Nombre,@Apellido,@Email,@Telefono,@Borrado)";
                    SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);

                    command.Parameters.AddWithValue("@Nombre", BoxNombre.Text);
                    command.Parameters.AddWithValue("@Apellido", BoxApellido.Text);
                    command.Parameters.AddWithValue("@Email", BoxEmail.Text);
                    command.Parameters.AddWithValue("@Telefono", BoxTelefono.Text);
                    command.Parameters.AddWithValue("@Borrado", 0);

                    try
                    {
                        command.ExecuteNonQuery();

                        MessageBox.Show("Creado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BoxNombre.Text = "";
                        BoxEmail.Text = "";
                        BoxApellido.Text = "";
                        BoxTelefono.Text = "";
                        return;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
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
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
