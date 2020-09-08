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
    public partial class EliminarBarrio : Form
    {
        public EliminarBarrio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((BoxEliminarBarrio.Text == ""))
            {
                MessageBox.Show("Por favor ingrese el nombre de un barrio a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

            
                SqlConnection conexion = new SqlConnection();
                
                //Definimos la cadena de conexion a la base de datos.
                conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                //La sentencia try...catch nos permite "atrapar" excepciones (Errores) y dar al usuario un mensaje más amigable.
                try
                {
                    //Abrimos la conexion a la base de datos.
                    conexion.Open();

                    //Construimos la consulta sql para buscar el usuario en la base de datos.
                    String consultaSql = string.Concat(" SELECT * ",
                                                       "   FROM Barrios ",
                                                       "  WHERE nombre =  '", this.BoxEliminarBarrio.Text , "'");

                    //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    // El metodo ExecuteReader retorna un objeto SqlDataReader con la respuesta de la base de datos. 
                    // Con SqlDataReader los datos se leen fila por fila, cambiando de fila cada vez que se ejecuta el metodo Read()
                    SqlDataReader reader = command.ExecuteReader();

                    // El metodo Read() lee la primera fila disponible, si NO existe una fila retorna false (la consulta no devolvio resultados).
                    if (reader.Read())
                    {

                        string IdBarrio = reader["id_barrio"].ToString();

                        reader.Close();

                        String cambio = "UPDATE dbo.Barrios SET borrado = @Borrado WHERE id_barrio = @valor";

                        SqlCommand comando = new SqlCommand(cambio, conexion);
                        comando.Parameters.AddWithValue("@valor", IdBarrio);
                        comando.Parameters.AddWithValue("@Borrado", 1);

                        comando.ExecuteNonQuery();

                        MessageBox.Show("Eliminado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra el barrio ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
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



                BoxEliminarBarrio.Text = "";
            }

            

        }
    }
}
