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
    public partial class ConsultarContactos : Form
    {

        private int Cont;
        public DataTable DataTable { get; private set; }

        public ConsultarContactos()
        {

            InitializeComponent();
            BoxUsuarioLogueado.Text = Dato.UsuarioLogueado;

            dataGridView.AllowUserToAddRows = false;

            btnModificar.Enabled = false;
            BtnEliminar.Enabled = false;

            Cont = 0;
            BoxFilas.Text = Cont.ToString();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
            SqlConnection conexion = new SqlConnection();


            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";


            try
            {
                //Abrimos la conexion a la base de datos.
                conexion.Open();

                if (CheckListado.Checked)
                {
                    //Construimos la consulta sql para buscar el usuario en la base de datos.
                    String consultaSql = string.Concat(" SELECT * ",
                                                       "   FROM Contactos ",
                                                       "  WHERE apellido LIKE '%" + this.BoxApellido.Text + "%' ");

                    //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    SqlDataAdapter reader = new SqlDataAdapter(command);

                    DataTable tabla = new DataTable();
                    reader.Fill(tabla);

                    String Filas = tabla.Rows.Count.ToString();

                    int temporal = Int16.Parse(Filas);
                    Cont = Cont + temporal;
                    BoxFilas.Text = Cont.ToString();

                    dataGridView.DataSource = tabla;
                    dataGridView.Columns.Remove("borrado");
                }
                else
                {


                    //Construimos la consulta sql para buscar el usuario en la base de datos.
                    String consultaSql = string.Concat(" SELECT * ",
                                                       "   FROM Contactos ",
                                                       "  WHERE (apellido LIKE '%" + this.BoxApellido.Text + "%') AND (borrado = 0) ");

                    //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    SqlDataAdapter reader = new SqlDataAdapter(command);

                    DataTable tabla = new DataTable();
                    reader.Fill(tabla);

                    String Filas = tabla.Rows.Count.ToString();

                    int temporal = Int16.Parse(Filas);
                    Cont = Cont + temporal;
                    BoxFilas.Text = Cont.ToString();

                    dataGridView.DataSource = tabla;
                    dataGridView.Columns.Remove("borrado");


                }



            }
            catch (SqlException ex)
            {

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



            BoxApellido.Text = "";
            Cont = 0;

            if (Dato.UsuarioLogueado != "administrador")
            {
                btnModificar.Enabled = false;
                BtnEliminar.Enabled = false;
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            String datoID = this.dataGridView.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("¿Esta seguro que desea eliminar este contacto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conexion = new SqlConnection();


                conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";


                try
                {

                    conexion.Open();


                    String cambio = "UPDATE dbo.Contactos SET borrado = @Borrado WHERE id_contacto = @valor";

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

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String datoID = this.dataGridView.CurrentRow.Cells[0].Value.ToString();

            Form formulario = new ModificarContacto(datoID);

            formulario.ShowDialog();
        }
    }
}
