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


        private String Fact = "none";
        public ReporteFactura(String NumFact)
        {
            
            InitializeComponent();

            Fact = NumFact;
            if (Fact != "none")
            {
                this.DataTable2TableAdapter.FillBy1(this.DataSetFacturas.DataTable2, Fact);
                this.reportViewer1.RefreshReport();
            }

        }

        public DateTime Fecha1 { get; set; }
        public DateTime Fecha2 { get; set; }

        private void ReporteBarrio_Load(object sender, EventArgs e)
        {
            this.DataTable2TableAdapter.Fill(this.DataSetFacturas.DataTable2);
            

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime Fecha1 = FechaDesde.Value;
            DateTime Fecha2 = FechaHasta.Value;

            Fact = "none";
            this.DataTable2TableAdapter.FillBy(this.DataSetFacturas.DataTable2, Fecha1, Fecha2);
            
            
            
            this.reportViewer1.RefreshReport();
        }
    }
}
