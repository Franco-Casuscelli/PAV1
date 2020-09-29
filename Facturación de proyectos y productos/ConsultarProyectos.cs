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
    public partial class ConsultarProyectos : Form
    {
        public ConsultarProyectos()
        {
            InitializeComponent();
            btnModificar.Enabled = false;
            BtnEliminar.Enabled = false;

            dataGridView.AllowUserToAddRows = false;


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

        private void btnBuscar_Click(object sender, EventArgs e)

        {
            if(BoxProducto.Text == "")
            {

                MessageBox.Show("Por favor seleccione un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BoxProducto.Text = "";
                return;
            }

            btnModificar.Enabled = true;
            BtnEliminar.Enabled = true;

            String IdProducto = "none";

            //BUSCAMOS EL ID DEL PRODUCTO
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlNombreRepetido = "Select * From Productos where nombre = '" + this.BoxProducto.Text + "'";
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

            if (IdProducto == "none")
            {
                MessageBox.Show("Por favor ingrese un producto existente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BoxProducto.Text = "";
                btnModificar.Enabled = false;
                BtnEliminar.Enabled = false;
                return;
            }
            
            
            if (CheckListado.Checked)
            {
                
                //Construimos la consulta sql para buscar el usuario en la base de datos.
                String consultaSql = string.Concat(" SELECT * ",
                                                   "   FROM Proyectos ",
                                                   "  WHERE id_producto = @ID ");

                //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                SqlCommand command = new SqlCommand(consultaSql, conexion);

                command.Parameters.AddWithValue("@ID", IdProducto);

                SqlDataAdapter reader = new SqlDataAdapter(command);

                DataTable tabla = new DataTable();
                reader.Fill(tabla);

                dataGridView.DataSource = tabla;
                dataGridView.Columns.Remove("id_producto");
                dataGridView.Columns.Remove("id_responsable");
                dataGridView.Columns.Remove("borrado");

            }
            else
            {
                
                //Construimos la consulta sql para buscar el usuario en la base de datos.
                String consultaSql = string.Concat(" SELECT * ",
                                                   "   FROM Proyectos ",
                                                   "  WHERE (id_producto = @ID) AND (borrado = 0)");

                //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                SqlCommand command = new SqlCommand(consultaSql, conexion);

                command.Parameters.AddWithValue("@ID", IdProducto);

                SqlDataAdapter reader = new SqlDataAdapter(command);

                DataTable tabla = new DataTable();
                reader.Fill(tabla);


                dataGridView.DataSource = tabla;
                dataGridView.Columns.Remove("id_producto");
                dataGridView.Columns.Remove("id_responsable");
                dataGridView.Columns.Remove("borrado");
            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 1)
            {
                MessageBox.Show("No se encuentra proyecto a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else
            {



                String datoID = this.dataGridView.CurrentCell.Value.ToString();


                if (MessageBox.Show("¿Esta seguro que desea Eliminar este proyecto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conexion = new SqlConnection();


                    conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";


                    try
                    {

                        conexion.Open();


                        String cambio = "UPDATE dbo.Proyectos SET borrado = @Borrado WHERE id_proyecto = @valor";

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count == 1)
            {
                MessageBox.Show("No se encuentra proyecto a modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else
            {
                String datoID = this.dataGridView.CurrentCell.Value.ToString();

                Form formulario = new ModificarProyecto(datoID);

                formulario.ShowDialog();

            }
        }

        private void ConsultarProyectos_Load(object sender, EventArgs e)
        {

        }
    }
}
