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

        private void btnCrear_Click(object sender, EventArgs e)
        {

            String IdProducto = "none";
            String IdResponsable = "none";


            //BUSCAMOS EL ID DEL PRODUCTO
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlNombreRepetido = "Select * From Productos where nombre = '"+this.BoxProducto.Text+"'";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IdProducto = reader["id_producto"].ToString();
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
            //CERRAMOS LA BUSQUEDA DE ID DEL PRODUCTO

            //BUSCAMOS EL ID DEL RESPONSABLE
            SqlConnection conexion2 = new SqlConnection();
            conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion2.Open();

                String consultaSqlNombreRepetido = "Select * From Usuarios where usuario = '" + this.BoxResponsable.Text + "'";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion2);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IdResponsable = reader["id_usuario"].ToString(); 
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
            //CERRAMOS LA BUSQUEDA DE ID DEL RESPONSABLE

            //CARGAMOS EL PROYECTO
            SqlConnection conexion3 = new SqlConnection();
            conexion3.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion3.Open();

                String consultaSqlNombreRepetido = "INSERT INTO dbo.Proyectos (id_producto,descripcion,version,alcance,id_responsable,borrado) VALUES (@Producto,@Descripcion,@Version,@Alcance,@Responsable,@Borrado)";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion3);

                command.Parameters.AddWithValue("@Producto", IdProducto);
                command.Parameters.AddWithValue("@Descripcion", BoxDescripcion.Text);
                command.Parameters.AddWithValue("@Version", BoxVersion.Text);
                command.Parameters.AddWithValue("@Alcance", BoxAlcance.Text);
                command.Parameters.AddWithValue("@Responsable", IdResponsable);
                command.Parameters.AddWithValue("@Borrado", 0);


                try
                {
                    if (IdResponsable != "none" && IdProducto != "none")
                    {
                        command.ExecuteNonQuery();

                        MessageBox.Show("Creado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BoxProducto.Text = "";
                        BoxResponsable.Text = "";
                        BoxDescripcion.Text = "";
                        BoxVersion.Text = "";
                        BoxAlcance.Text = "";

                        return;
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione un Producto y/o Responsable", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
                if (conexion3.State == ConnectionState.Open)
                {
                    conexion3.Close();
                }
            }

        }

        private void CrearProyecto_Load(object sender, EventArgs e)
        {

        }

        private void BoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

