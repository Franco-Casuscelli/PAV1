namespace Facturación_de_proyectos_y_productos
{
    partial class ConsultarFactura
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
            this.BoxNumFact = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblcontacto = new System.Windows.Forms.Label();
            this.BoxCliente = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dataFecha = new System.Windows.Forms.DateTimePicker();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.BoxPrecio = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.BoxResponsable = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.BoxUsuarioLogueado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxNumFact
            // 
            this.BoxNumFact.FormattingEnabled = true;
            this.BoxNumFact.Location = new System.Drawing.Point(288, 41);
            this.BoxNumFact.Name = "BoxNumFact";
            this.BoxNumFact.Size = new System.Drawing.Size(162, 21);
            this.BoxNumFact.TabIndex = 5;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(198, 44);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(83, 13);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Numero Factura";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(265, 85);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 23);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Buscar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(488, 190);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(114, 20);
            this.txtCuit.TabIndex = 29;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(450, 193);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 28;
            this.lblCuit.Text = "CUIT";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(302, 190);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(114, 20);
            this.txtDireccion.TabIndex = 27;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(244, 193);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 26;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblcontacto
            // 
            this.lblcontacto.AutoSize = true;
            this.lblcontacto.Location = new System.Drawing.Point(54, 193);
            this.lblcontacto.Name = "lblcontacto";
            this.lblcontacto.Size = new System.Drawing.Size(39, 13);
            this.lblcontacto.TabIndex = 24;
            this.lblcontacto.Text = "Cliente";
            // 
            // BoxCliente
            // 
            this.BoxCliente.Location = new System.Drawing.Point(99, 190);
            this.BoxCliente.Name = "BoxCliente";
            this.BoxCliente.Size = new System.Drawing.Size(114, 20);
            this.BoxCliente.TabIndex = 30;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(385, 149);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(96, 13);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha de creación";
            // 
            // dataFecha
            // 
            this.dataFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFecha.Location = new System.Drawing.Point(487, 143);
            this.dataFecha.Name = "dataFecha";
            this.dataFecha.Size = new System.Drawing.Size(115, 20);
            this.dataFecha.TabIndex = 32;
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(54, 524);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(69, 13);
            this.lblResponsable.TabIndex = 37;
            this.lblResponsable.Text = "Responsable";
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(57, 260);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(545, 231);
            this.dataGrid.TabIndex = 33;
            // 
            // BoxPrecio
            // 
            this.BoxPrecio.Location = new System.Drawing.Point(489, 521);
            this.BoxPrecio.MaxLength = 10;
            this.BoxPrecio.Name = "BoxPrecio";
            this.BoxPrecio.Size = new System.Drawing.Size(113, 20);
            this.BoxPrecio.TabIndex = 35;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(418, 524);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(65, 13);
            this.lblImporte.TabIndex = 34;
            this.lblImporte.Text = "Importe total";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(285, 234);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(91, 13);
            this.lblDetalle.TabIndex = 39;
            this.lblDetalle.Text = "Detalle de factura";
            // 
            // BoxResponsable
            // 
            this.BoxResponsable.Location = new System.Drawing.Point(129, 521);
            this.BoxResponsable.MaxLength = 10;
            this.BoxResponsable.Name = "BoxResponsable";
            this.BoxResponsable.Size = new System.Drawing.Size(113, 20);
            this.BoxResponsable.TabIndex = 40;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(265, 575);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(129, 26);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.Text = "Cerrar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // BoxUsuarioLogueado
            // 
            this.BoxUsuarioLogueado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxUsuarioLogueado.Enabled = false;
            this.BoxUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUsuarioLogueado.Location = new System.Drawing.Point(9, 612);
            this.BoxUsuarioLogueado.Margin = new System.Windows.Forms.Padding(0);
            this.BoxUsuarioLogueado.MaxLength = 50;
            this.BoxUsuarioLogueado.Name = "BoxUsuarioLogueado";
            this.BoxUsuarioLogueado.Size = new System.Drawing.Size(120, 15);
            this.BoxUsuarioLogueado.TabIndex = 43;
            this.BoxUsuarioLogueado.TextChanged += new System.EventHandler(this.BoxUsuarioLogueado_TextChanged);
            // 
            // ConsultarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 626);
            this.Controls.Add(this.BoxUsuarioLogueado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.BoxResponsable);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.BoxPrecio);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.dataFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.BoxCliente);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblcontacto);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BoxNumFact);
            this.Controls.Add(this.lblCliente);
            this.MinimizeBox = false;
            this.Name = "ConsultarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar facturas";
            this.Load += new System.EventHandler(this.ConsultarFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BoxNumFact;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblcontacto;
        private System.Windows.Forms.TextBox BoxCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dataFecha;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox BoxPrecio;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox BoxResponsable;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox BoxUsuarioLogueado;
    }
}