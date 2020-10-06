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
 
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        public bool ValidarUsuario(string pUsuario, string pPassword)
        {
            bool usuarioValido = false;

            SqlConnection conexion = new SqlConnection();

            conexion.ConnectionString = "Data Source = (localdb)\\SQLEXPRESS; Initial Catalog = TPI; Integrated Security = True";

            try
            {
                conexion.Open();

                String consultaSql = string.Concat(" SELECT * ",
                                                   "   FROM Usuarios ",
                                                   "  WHERE usuario =  '", pUsuario, "'");

                SqlCommand command = new SqlCommand(consultaSql, conexion);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    
                    if (reader["password"].ToString() == pPassword)
                    {
                       
                        usuarioValido = true;
                    }
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
            return usuarioValido;
        }
        
        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
                if ((txtUsuario.Text == ""))
                {
                    MessageBox.Show("Se debe ingresar un usuario.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if ((txtPassword.Text == ""))
                {
                    MessageBox.Show("Se debe ingresar una contraseña.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (ValidarUsuario(txtUsuario.Text, txtPassword.Text))
                {
                    MessageBox.Show("Logueado correctamente", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Dato.UsuarioLogueado = txtUsuario.Text;
                    this.Close();
                }
                else
                {
                    txtUsuario.Text = "";
                    txtPassword.Text = "";
                    MessageBox.Show("Ingrese un usuario y contraseña correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return keyData == (Keys.Alt | Keys.F4);
        }
    }
    }


    


