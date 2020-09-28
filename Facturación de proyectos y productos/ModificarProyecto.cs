﻿using System;
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
    public partial class ModificarProyecto : Form
    {
        String ID;
        public ModificarProyecto(String datoID)
        {
            InitializeComponent();
            ID = datoID;

            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSqlNombreRepetido = "Select * From Proyectos where id_proyecto = @valor";
                SqlCommand command = new SqlCommand(consultaSqlNombreRepetido, conexion);

                command.Parameters.AddWithValue("@valor", ID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    BoxDescripcion.Text = reader["descripcion"].ToString();
                    BoxVersion.Text = reader["version"].ToString();
                    BoxAlcance.Text = reader["alcance"].ToString();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarProyecto_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if ((BoxDescripcion.Text == "" || BoxVersion.Text == "" || BoxAlcance.Text == ""))
            {
                MessageBox.Show("No se admineten campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                SqlConnection conexion = new SqlConnection();
                conexion.ConnectionString = "Data Source=(localdb)\\SQLEXPRESS;Initial Catalog=TPI;Integrated Security=True";

                try
                {
                    
                    conexion.Open();

                    String consultaSql = "UPDATE dbo.Proyectos SET descripcion = @Descripcion, version = @Version, alcance = @Alcance WHERE id_proyecto = '" + this.ID + "'";

                    //Creamos un objeto command para luego ejecutar la consulta sobre la base de datos
                    SqlCommand command = new SqlCommand(consultaSql, conexion);

                    command.Parameters.AddWithValue("@Descripcion", BoxDescripcion.Text);
                    command.Parameters.AddWithValue("@Version", BoxVersion.Text);
                    command.Parameters.AddWithValue("@Alcance", BoxAlcance.Text);

                    
                    try
                    {
                        command.ExecuteNonQuery();

                        MessageBox.Show("Modificado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


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

                this.Close();

            }

        
        }
    }
}
