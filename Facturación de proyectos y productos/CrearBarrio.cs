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
    public partial class CrearBarrio : Form
    {
        public CrearBarrio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if ((BoxBarrio.Text == ""))
            {
                MessageBox.Show("Por favor ingrese el nombre de un barrio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                SqlConnection conexion = new SqlConnection();

                
                conexion.ConnectionString = "Data Source=(localdb)\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";

                
                try
                {
                    

                    //Abrimos la conexion a la base de datos.
                    conexion.Open();


                    //Construimos la consulta sql para buscar el usuario en la base de datos.
                    String consultaSql = "INSERT INTO dbo.Barrios (nombre,borrado) VALUES (@Nombre,@Borrado)";

                    //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    command.Parameters.AddWithValue("@Nombre", BoxBarrio.Text);
                    command.Parameters.AddWithValue("@Borrado", 0);
               


                    
                    try
                    {
                        command.ExecuteNonQuery();
                       
                        MessageBox.Show("Creado con exito!","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
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
                        //Cerramos la conexion
                        conexion.Close();
                    }
                }

     
                BoxBarrio.Text = "";

            }
        }
    }
}
