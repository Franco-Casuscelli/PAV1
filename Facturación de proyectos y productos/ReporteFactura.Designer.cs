namespace Facturación_de_proyectos_y_productos
{
    partial class ReporteFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFacturas = new Facturación_de_proyectos_y_productos.DataSetFacturas();
            this.FacturasTableAdapter = new Facturación_de_proyectos_y_productos.DataSetFacturasTableAdapters.FacturasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetFacturas";
            reportDataSource1.Value = this.FacturasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Facturación_de_proyectos_y_productos.ReporteFacturas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(687, 304);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturasBindingSource
            // 
            this.FacturasBindingSource.DataMember = "Facturas";
            this.FacturasBindingSource.DataSource = this.DataSetFacturas;
            // 
            // DataSetFacturas
            // 
            this.DataSetFacturas.DataSetName = "DataSetFacturas";
            this.DataSetFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturasTableAdapter
            // 
            this.FacturasTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(687, 304);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte Facturas";
            this.Load += new System.EventHandler(this.ReporteBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturasBindingSource;
        private DataSetFacturas DataSetFacturas;
        private DataSetFacturasTableAdapters.FacturasTableAdapter FacturasTableAdapter;
    }
}