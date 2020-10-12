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

        private DataTable dt;
        public ReporteFactura()
        {
            InitializeComponent();
        }

        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }

        private void ReporteBarrio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSetFacturas.Rango_Fecha' Puede moverla o quitarla según sea necesario.
            this.Rango_FechaTableAdapter.Fill(this.DataSetFacturas.Rango_Fecha,Fecha1,Fecha2);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime Fecha1 = FechaDesde.Value;
            DateTime Fecha2 = FechaHasta.Value;

            this.Rango_FechaTableAdapter.Fill(this.DataSetFacturas.Rango_Fecha, Fecha1, Fecha2);

            this.reportViewer1.RefreshReport();
        }
    }
}
