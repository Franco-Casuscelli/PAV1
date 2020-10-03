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
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;


            SqlConnection conexion = new SqlConnection();


            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                
                conexion.Open();

                if (chbMostrarBorrado.Checked)
                {
                    
                    String consultaSql = string.Concat(" SELECT * ",
                                                       "   FROM Clientes ",
                                                       "  WHERE cuit LIKE '%" + this.txtCuitConsulta.Text + "%' ");

                    
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    SqlDataAdapter reader = new SqlDataAdapter(command);

                    DataTable tabla = new DataTable();
                    reader.Fill(tabla);

                    grillaCliente.DataSource = tabla;
                    grillaCliente.Columns.Remove("borrado");
                }
                else
                {


                    
                    String consultaSql = string.Concat(" SELECT * ",
                                                       "   FROM Clientes ",
                                                       "  WHERE (cuit LIKE '%" + this.txtCuitConsulta.Text + "%') AND (borrado = 0) ");

                    
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    SqlDataAdapter reader = new SqlDataAdapter(command);

                    DataTable tabla = new DataTable();
                    reader.Fill(tabla);

                    grillaCliente.DataSource = tabla;
                    grillaCliente.Columns.Remove("borrado");


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



            txtCuitConsulta.Text = "";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (grillaCliente.Rows.Count == 1)
            {
                MessageBox.Show("No se encuentra proyecto a modificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else
            {
                String datoID = this.grillaCliente.CurrentCell.Value.ToString();

                Form formulario = new ModificarCliente(datoID);

                formulario.ShowDialog();

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (grillaCliente.Rows.Count == 1)
            {
                MessageBox.Show("No se encuentra proyecto a eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            else
            {



                String datoID = this.grillaCliente.CurrentCell.Value.ToString();


                if (MessageBox.Show("¿Esta seguro que desea Eliminar este proyecto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlConnection conexion = new SqlConnection();


                    conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";


                    try
                    {

                        conexion.Open();


                        String cambio = "UPDATE dbo.Clientes SET borrado = @Borrado WHERE id_cliente = @valor";

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

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
