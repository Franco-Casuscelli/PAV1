using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturación_de_proyectos_y_productos
{
    public partial class ModificarBarrio : Form
    {
        String ID;
        public ModificarBarrio(String datoID)
        {
            InitializeComponent();
            ID = datoID;
        }

        private void lblCrearBarrio_Click(object sender, EventArgs e)
        {

        }

        private void BoxBarrio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarBarrio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ID);
        }
    }
}
