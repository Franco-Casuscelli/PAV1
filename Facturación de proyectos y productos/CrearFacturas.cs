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
    public partial class CrearFacturas : Form
    {

        private DataTable dt;
        private int Cont;
        private String IDContacto;
        private String ClienteCuit;
        private String IdResponsable;
        private String IdFactura;
        private int NumeroOrden;

        public CrearFacturas()
        {

            InitializeComponent();

            BoxUsuarioLogueado.Text = Dato.UsuarioLogueado;

            dt = new DataTable();
            dt.Columns.Add("Proyecto");
            dt.Columns.Add("Descripcion");
            dt.Columns.Add("Version");
            dt.Columns.Add("Alcance");
            dt.Columns.Add("Precio");

            dataGrid.DataSource = dt;
            dataGrid.AllowUserToAddRows = false;

            txtNumeroFactura.Enabled = false;
            txtDireccion.Enabled = false;
            txtCuit.Enabled = false;
            BtnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            BoxPrecio.Enabled = false;

            BoxTipoFact.Items.Add("A");
            BoxTipoFact.Items.Add("B");
            BoxTipoFact.Items.Add("C");

            int Cont = 0;
            String Formato = "2020-0000";


            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlNombreRepetido = "Select * From Proyectos";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BoxProducto.Items.Add(reader["id_proyecto"].ToString());
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
            //--------------------------------------------------------------------------

            SqlConnection conexion2 = new SqlConnection();
            conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion2.Open();

                String consultaSqlNombreRepetido = "Select * From Facturas";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion2);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Cont = Cont + 1;
                    
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
            Cont = Cont + 1;
            NumeroOrden = Cont;
            txtNumeroFactura.Text = (Formato + Cont);

            //--------------------------------------------------------------------------

            SqlConnection conexion3 = new SqlConnection();
            conexion3.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion3.Open();

                String consultaSqlNombreRepetido = "Select * From Contactos";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion3);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BoxCliente.Items.Add(reader["nombre"].ToString() + " " + reader["apellido"].ToString());
                }
                reader.Close();
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
            //-------------------------------------

            SqlConnection conexion4 = new SqlConnection();
            conexion4.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion4.Open();

                String consultaSqlNombreRepetido = "Select * From Usuarios";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion4);

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
                if (conexion4.State == ConnectionState.Open)
                {
                    conexion4.Close();
                }
            }

        }

        private void CrearFacturas_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir del formulario?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            BtnEliminar.Enabled = true;
            btnGuardar.Enabled = true;

            if ((BoxProducto.Text == "") || (BoxPrecioProducto.Text == ""))
            {
                MessageBox.Show("Por favor ingrese un Proyecto y/o Precio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion.Open();

                    String consultaSqlNombreRepetido = "Select * From Proyectos where id_proyecto = '" + this.BoxProducto.Text + "'";
                    SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        DataRow row = dt.NewRow();

                        row["Proyecto"] = reader["id_proyecto"].ToString();
                        row["Descripcion"] = reader["descripcion"].ToString();
                        row["Version"] = reader["version"].ToString();
                        row["Alcance"] = reader["alcance"].ToString();
                        row["Precio"] = BoxPrecioProducto.Text;

                        dt.Rows.Add(row);

                        int temporal = Int16.Parse(BoxPrecioProducto.Text);
                        Cont = Cont + temporal;
                        BoxPrecio.Text = Cont.ToString();

                        BoxProducto.Text = "";
                        BoxPrecioProducto.Text = "";


                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se encuentra el numero del proyecto ingresado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BoxProducto.Text = "";
                        BoxPrecioProducto.Text = "";
                    }
                    reader.Close();

                    //dataGridView.Rows.Add(reader.Read());
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
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

            String precioDescontar = this.dataGrid.CurrentRow.Cells[4].Value.ToString();

            int temporal = Int16.Parse(precioDescontar);
            Cont = Cont - temporal;
            BoxPrecio.Text = Cont.ToString();

            dataGrid.Rows.Remove(this.dataGrid.CurrentRow);

            String Filas = this.dataGrid.Rows.Count.ToString();
            int FilasINT = Int16.Parse(Filas);

            if (FilasINT == 0)
            {
                BtnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
            }

        }

        private void BoxPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void BoxPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar)) || (Char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void BoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            txtDireccion.Text = "";
            txtCuit.Text = "";

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlNombreRepetido = "Select * From Contactos";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    String nombreContacto = (reader["nombre"].ToString() + " " + reader["apellido"].ToString());

                    if (BoxCliente.Text == nombreContacto)
                    {
                        IDContacto = reader["id_contacto"].ToString();
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
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            //---------------------------
            SqlConnection conexion2 = new SqlConnection();
            conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion2.Open();

                String consultaSqlNombreRepetido = "Select * From Clientes where id_contacto = '" + IDContacto + "'";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion2);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    txtDireccion.Text = reader["calle"].ToString() + " " + reader["numero"].ToString();
                    txtCuit.Text = reader["cuit"].ToString();
                }
                reader.Close();
                if (txtDireccion.Text == "" || txtCuit.Text == "")
                {
                    MessageBox.Show(" El contacto seleccionado no está registado \n por favor cree el cliente previamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //List<String> proyectos = new List<String>();

            if (txtDireccion.Text == "" || txtCuit.Text == "" || BoxResponsable.Text == "" || BoxTipoFact.Text == "")
            {

                if(txtDireccion.Text == "" || txtCuit.Text == "")
                {
                    MessageBox.Show("Seleccione un contacto registrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (BoxTipoFact.Text == "")
                {
                    MessageBox.Show("Seleccione un tipo de factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (BoxResponsable.Text == "")
                {
                    MessageBox.Show("Seleccione un responsable", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      
                }

            }  
            else
            {


                //buscamos los datos

                SqlConnection conexion2 = new SqlConnection();
                conexion2.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                try
                {
                    conexion2.Open();

                    String consultaSqlNombreRepetido = "Select * From Clientes where cuit = '" + this.txtCuit.Text + "'";
                    SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion2);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        ClienteCuit = reader["id_cliente"].ToString();

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

                    //-----------------------------------------

                    SqlConnection conexion3 = new SqlConnection();
                    conexion3.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                    try
                    {
                        conexion3.Open();

                        String consultaSqlNombreRepetido = "Select * From Usuarios where usuario = '" + this.BoxResponsable.Text + "'";
                        SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion3);

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
                        if (conexion3.State == ConnectionState.Open)
                        {
                            conexion3.Close();
                        }

                        //arrancamos guardando la Factura

                        SqlConnection conexion = new SqlConnection();
                        conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                        try
                        {
                            conexion.Open();

                            String consultaSqlNombreRepetido = "INSERT INTO dbo.Facturas (numero_factura,id_cliente,fecha,id_usuario_creador,borrado) VALUES (@NumFact,@Cliente,@Fecha,@Responsable,@Borrado)";
                            SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);

                            command.Parameters.AddWithValue("@NumFact", txtNumeroFactura.Text);
                            command.Parameters.AddWithValue("@Cliente", ClienteCuit);
                            command.Parameters.AddWithValue("@Fecha", dataFecha.Value);
                            command.Parameters.AddWithValue("@Responsable", IdResponsable);
                            command.Parameters.AddWithValue("@Borrado", 0);

                            command.ExecuteNonQuery();
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

                        //ahora cargamos el detalle de factura


                        SqlConnection conexion5 = new SqlConnection();
                        conexion5.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                        try
                        {
                            conexion5.Open();

                            String consultaSqlNombreRepetido = "Select * From Facturas where numero_factura = '" + this.txtNumeroFactura.Text + "'";
                            SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion5);

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                IdFactura = reader["id_factura"].ToString();

                            }
                            reader.Close();

                        }

                        catch (SqlException ex)
                        {
                            MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            if (conexion5.State == ConnectionState.Open)
                            {
                                conexion5.Close();
                            }

                            //-----------------


                            SqlConnection conexion4 = new SqlConnection();
                            conexion4.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

                            try
                            {
                                conexion4.Open();

                                for (int i = 0; i < dataGrid.Rows.Count; i++)
                                {
                                    String consultaSqlNombreRepetido = "INSERT INTO dbo.FacturasDetalle (id_factura,numero_orden,id_proyecto,precio,borrado) VALUES (@id_factura,@numero_orden,@id_proyecto,@precio,@Borrado)";
                                    SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion4);



                                    command.Parameters.AddWithValue("@id_factura", IdFactura);
                                    command.Parameters.AddWithValue("@id_proyecto", dataGrid.Rows[i].Cells[0].Value.ToString());
                                    command.Parameters.AddWithValue("@numero_orden", NumeroOrden);
                                    command.Parameters.AddWithValue("@precio", dataGrid.Rows[i].Cells[4].Value.ToString());
                                    command.Parameters.AddWithValue("@Borrado", 0);

                                    command.ExecuteNonQuery();

                                    //proyectos.Add(dataGrid.Rows[i].Cells[0].Value.ToString());
                                }

                                MessageBox.Show("La factura fue creada con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();


                            }

                            catch (SqlException ex)
                            {
                                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            finally
                            {
                                if (conexion4.State == ConnectionState.Open)
                                {
                                    conexion4.Close();
                                }

                            }

                        }
                    }
                }
            }
        }

        private void BoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void BoxResponsable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BoxTipoFact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BoxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BoxProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void BoxResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}



