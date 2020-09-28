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
    public partial class CrearProyecto : Form
    {
        public CrearProyecto()
        {
            InitializeComponent();



            // llenamos el combo box de responsable

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlNombreRepetido = "Select * From Usuarios";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BoxResponsable.Items.Add(reader["usuario"].ToString());
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

            //Cerramos el combo box


            // llenamos el combo box de producto

            SqlConnection conexion2 = new SqlConnection();
            conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion2.Open();

                String consultaSqlNombreRepetido = "Select * From Productos";
                SqlCommand command2 = new SqlCommand(consultaSqlNombreRepetido, conexion2);

                SqlDataReader reader = command2.ExecuteReader();

                while (reader.Read())
                {
                    BoxProducto.Items.Add(reader["nombre"].ToString());
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


        }

        private void BoxDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir del formulario?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BoxResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            



            


        }

    }
}

