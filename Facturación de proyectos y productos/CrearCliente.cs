using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturación_de_proyectos_y_productos
{
    public partial class frmCrearCliente : Form
    {
        public frmCrearCliente()
        {
            InitializeComponent();

            BoxUsuarioLogueado.Text = Dato.UsuarioLogueado;

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlBarrio = "Select * From Barrios where borrado = 0";
                SqlCommand command = new SqlCommand(consultaSqlBarrio, conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbBarrio.Items.Add(reader["nombre"].ToString());
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
            SqlConnection conexion2 = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlContacto = "Select * From Contactos";
                SqlCommand command = new SqlCommand(consultaSqlContacto, conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbContacto.Items.Add(reader["nombre"].ToString() + " " + reader["apellido"].ToString());
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

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string idBarrio = "none";
            string idContacto = "none";

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlBarrio1 = "Select * From Barrios where nombre = '" + this.cmbBarrio.Text + "'";
                SqlCommand command = new SqlCommand(consultaSqlBarrio1, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    idBarrio = reader["id_barrio"].ToString();
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
            SqlConnection conexion2 = new SqlConnection();
            conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion2.Open();

                String consultaSqlContacto = "Select * From Contactos";
                SqlCommand command = new SqlCommand(consultaSqlContacto, conexion2);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    String nombreContacto = (reader["nombre"].ToString() + " " + reader["apellido"].ToString());

                    if (cmbContacto.Text == nombreContacto)
                    {
                        idContacto = reader["id_contacto"].ToString();
                    }
                     
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


            if ((txtRazonSocial.Text == ""))
            {
                MessageBox.Show("Por favor ingrese la Razon social correspondiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((txtCuit.Text == ""))
            {
                MessageBox.Show("Por favor ingrese el Cuit correspondiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((txtNumero.Text == ""))
            {
                MessageBox.Show("Por favor ingrese el numero de la calle", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((txtCalle.Text == ""))
            {
                MessageBox.Show("Por favor ingrese la calle correspondiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                SqlConnection conexion3 = new SqlConnection();
                conexion3.ConnectionString = "Data Source=(localdb)\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";


                try
                {


                    //Abrimos la conexion a la base de datos.
                    conexion3.Open();

                    String consultaSqlNombreRepetido = "Select * From Clientes where razon_social = '" + this.txtRazonSocial.Text + "' ";
                    SqlCommand command2 = new SqlCommand(consultaSqlNombreRepetido, conexion3);

                    SqlDataReader reader = command2.ExecuteReader();

                    //buscamos si ya esta cargado ese Cuit
                    if (reader.Read())
                    {
                        string Cuit = reader["cuit"].ToString();
                        

                        if (Cuit == txtCuit.Text)
                        {
                            MessageBox.Show("El Cuit Ingresado ya esta registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtCuit.Text = "";
                            return;

                        }
                        reader.Close();

                    }
                    //si llegamos hasta aca no esta repetido entonces cerramos el reader anterior
                    reader.Close();


                    String consultaSql = "INSERT INTO dbo.Clientes (cuit,razon_social,borrado,calle,numero,fecha_alta,id_barrio,id_contacto) VALUES (@Cuit,@Razon_social,@Borrado,@Calle,@Numero,@Fecha_alta,@id_barrio,@id_contacto)";
                    
                    //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                    SqlCommand command = new SqlCommand(consultaSql, conexion3);

                    command.Parameters.AddWithValue("@Cuit", txtCuit.Text);
                    command.Parameters.AddWithValue("@Razon_social", txtRazonSocial.Text);
                    command.Parameters.AddWithValue("@Calle", txtCalle.Text);
                    command.Parameters.AddWithValue("@Numero", txtNumero.Text);
                    command.Parameters.AddWithValue("@Fecha_alta", dtaFecha.Value);
                    command.Parameters.AddWithValue("@Borrado", 0);
                    command.Parameters.AddWithValue("@id_barrio", idBarrio);
                    command.Parameters.AddWithValue("@id_contacto", idContacto);

                    try
                    {
                        command.ExecuteNonQuery();

                        MessageBox.Show("Creado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRazonSocial.Text = "";
                        txtCuit.Text = "";
                        txtNumero.Text = "";
                        txtCalle.Text = "";
                        cmbBarrio.Text = "";
                        cmbContacto.Text = "";

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
                        //Cerramos la conexion
                        conexion.Close();
                    }
                }


                txtCalle.Text = "";
                txtRazonSocial.Text = "";
                txtNumero.Text = "";
                txtCuit.Text = "";


            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtaFecha_ValueChanged(object sender, EventArgs e)
        {

        }


        private void frmCrearCliente_Load(object sender, EventArgs e)
        {

        }


        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

    }
}
