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
            this.Rango_FechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetFacturas = new Facturación_de_proyectos_y_productos.DataSetFacturas();
            this.FacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturasTableAdapter = new Facturación_de_proyectos_y_productos.DataSetFacturasTableAdapters.FacturasTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.FechaDesde = new System.Windows.Forms.DateTimePicker();
            this.FechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.Rango_FechaTableAdapter = new Facturación_de_proyectos_y_productos.DataSetFacturasTableAdapters.Rango_FechaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Rango_FechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Rango_FechaBindingSource
            // 
            this.Rango_FechaBindingSource.DataMember = "Rango_Fecha";
            this.Rango_FechaBindingSource.DataSource = this.DataSetFacturas;
            // 
            // DataSetFacturas
            // 
            this.DataSetFacturas.DataSetName = "DataSetFacturas";
            this.DataSetFacturas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturasBindingSource
            // 
            this.FacturasBindingSource.DataMember = "Facturas";
            this.FacturasBindingSource.DataSource = this.DataSetFacturas;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Rango_FechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Facturación_de_proyectos_y_productos.ReporteFacturaFecha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(752, 433);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FacturasTableAdapter
            // 
            this.FacturasTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha desde:";
            // 
            // FechaDesde
            // 
            this.FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaDesde.Location = new System.Drawing.Point(103, 27);
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.Size = new System.Drawing.Size(98, 20);
            this.FechaDesde.TabIndex = 2;
            // 
            // FechaHasta
            // 
            this.FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaHasta.Location = new System.Drawing.Point(327, 25);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.Size = new System.Drawing.Size(98, 20);
            this.FechaHasta.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha hasta:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(661, 23);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(103, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Rango_FechaTableAdapter
            // 
            this.Rango_FechaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(776, 515);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.FechaHasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechaDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "ReporteFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reporte facturas de proyectos";
            this.Load += new System.EventHandler(this.ReporteBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Rango_FechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturasBindingSource;
        private DataSetFacturas DataSetFacturas;
        private DataSetFacturasTableAdapters.FacturasTableAdapter FacturasTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechaDesde;
        private System.Windows.Forms.DateTimePicker FechaHasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.BindingSource Rango_FechaBindingSource;
        private DataSetFacturasTableAdapters.Rango_FechaTableAdapter Rango_FechaTableAdapter;
    }
}