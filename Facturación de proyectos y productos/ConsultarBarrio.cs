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
    public partial class ConsultarBarrio : Form
    {
        public DataTable DataTable { get; private set; }

        public ConsultarBarrio()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lblBuscarBarrio_Click(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if ((TextConsultaBarrio.Text == ""))
            {
                MessageBox.Show("Por favor ingrese el nombre de un barrio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                                       "  WHERE nombre = @Nombre ");

                    //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    command.Parameters.AddWithValue("@Nombre", TextConsultaBarrio.Text);

                    // El metodo ExecuteReader retorna un objeto SqlDataReader con la respuesta de la base de datos. 
                    // Con SqlDataReader los datos se leen fila por fila, cambiando de fila cada vez que se ejecuta el metodo Read()
                    SqlDataAdapter reader = new SqlDataAdapter(command);

                    DataTable tabla = new DataTable();
                    reader.Fill(tabla);

                    dataGridView.DataSource = tabla;
                    // El metodo Read() lee la primera fila disponible, si NO existe una fila retorna false (la consulta no devolvio resultados).

                   
                    

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



                //TextConsultaBarrio.Text = "";
            }

        }

        private void TextConsultaBarrio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
