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
    public partial class ReporteFactura : Form
    {
        public ReporteFactura()
        {
            InitializeComponent();
        }

        private void ReporteBarrio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFacturas.Facturas' Puede moverla o quitarla según sea necesario.
            this.FacturasTableAdapter.Fill(this.DataSetFacturas.Facturas);

            this.reportViewer1.RefreshReport();
        }
    }
}
