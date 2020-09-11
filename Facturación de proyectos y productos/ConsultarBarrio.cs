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
                                                       "  WHERE nombre LIKE '%"+this.TextConsultaBarrio.Text+"%' ");

                    //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    SqlDataAdapter reader = new SqlDataAdapter(command);

                    DataTable tabla = new DataTable();
                    reader.Fill(tabla);

                    dataGridView.DataSource = tabla;
                    
                   
                    

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



                TextConsultaBarrio.Text = "";
            

        }

        private void TextConsultaBarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String datoID = this.dataGridView.CurrentCell.Value.ToString();
            //MessageBox.Show(datoID);


            Form formulario = new ModificarBarrio(datoID);
            
            formulario.ShowDialog();

        }
    }
}
