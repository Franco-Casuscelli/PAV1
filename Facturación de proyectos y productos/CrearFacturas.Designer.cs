namespace Facturación_de_proyectos_y_productos
{
    partial class CrearFacturas
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
            this.TipoFact = new System.Windows.Forms.Label();
            this.BoxTipoFact = new System.Windows.Forms.ComboBox();
            this.BoxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.NumFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dataFecha = new System.Windows.Forms.DateTimePicker();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblProyecto = new System.Windows.Forms.Label();
            this.BoxProducto = new System.Windows.Forms.ComboBox();
            this.BoxPrecioProducto = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TipoFact
            // 
            this.TipoFact.AutoSize = true;
            this.TipoFact.Location = new System.Drawing.Point(36, 37);
            this.TipoFact.Name = "TipoFact";
            this.TipoFact.Size = new System.Drawing.Size(67, 13);
            this.TipoFact.TabIndex = 0;
            this.TipoFact.Text = "Tipo de Fact";
            // 
            // BoxTipoFact
            // 
            this.BoxTipoFact.FormattingEnabled = true;
            this.BoxTipoFact.Location = new System.Drawing.Point(109, 34);
            this.BoxTipoFact.Name = "BoxTipoFact";
            this.BoxTipoFact.Size = new System.Drawing.Size(113, 21);
            this.BoxTipoFact.TabIndex = 1;
            // 
            // BoxCliente
            // 
            this.BoxCliente.FormattingEnabled = true;
            this.BoxCliente.Location = new System.Drawing.Point(109, 74);
            this.BoxCliente.Name = "BoxCliente";
            this.BoxCliente.Size = new System.Drawing.Size(113, 21);
            this.BoxCliente.TabIndex = 3;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(36, 77);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente";
            // 
            // NumFactura
            // 
            this.NumFactura.AutoSize = true;
            this.NumFactura.Location = new System.Drawing.Point(250, 37);
            this.NumFactura.Name = "NumFactura";
            this.NumFactura.Size = new System.Drawing.Size(53, 13);
            this.NumFactura.TabIndex = 4;
            this.NumFactura.Text = "Num Fact";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(309, 34);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(113, 20);
            this.txtNumeroFactura.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(250, 77);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(308, 74);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(114, 20);
            this.txtDireccion.TabIndex = 7;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(459, 37);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha";
            // 
            // dataFecha
            // 
            this.dataFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFecha.Location = new System.Drawing.Point(502, 34);
            this.dataFecha.Name = "dataFecha";
            this.dataFecha.Size = new System.Drawing.Size(114, 20);
            this.dataFecha.TabIndex = 9;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(459, 77);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 10;
            this.lblCuit.Text = "CUIT";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(502, 74);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(114, 20);
            this.txtCuit.TabIndex = 11;
            // 
            // lblProyecto
            // 
            this.lblProyecto.AutoSize = true;
            this.lblProyecto.Location = new System.Drawing.Point(57, 190);
            this.lblProyecto.Name = "lblProyecto";
            this.lblProyecto.Size = new System.Drawing.Size(77, 13);
            this.lblProyecto.TabIndex = 13;
            this.lblProyecto.Text = "ID de proyecto";
            // 
            // BoxProducto
            // 
            this.BoxProducto.FormattingEnabled = true;
            this.BoxProducto.Location = new System.Drawing.Point(140, 185);
            this.BoxProducto.Name = "BoxProducto";
            this.BoxProducto.Size = new System.Drawing.Size(88, 21);
            this.BoxProducto.TabIndex = 15;
            // 
            // BoxPrecioProducto
            // 
            this.BoxPrecioProducto.Location = new System.Drawing.Point(289, 187);
            this.BoxPrecioProducto.MaxLength = 10;
            this.BoxPrecioProducto.Name = "BoxPrecioProducto";
            this.BoxPrecioProducto.Size = new System.Drawing.Size(88, 20);
            this.BoxPrecioProducto.TabIndex = 19;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(440, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(527, 184);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminar.TabIndex = 23;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 231);
            this.dataGridView1.TabIndex = 24;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(286, 136);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(91, 13);
            this.lblDetalle.TabIndex = 25;
            this.lblDetalle.Text = "Detalle de factura";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(514, 517);
            this.textBox1.MaxLength = 10;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 27;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(439, 520);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(69, 13);
            this.lblImporte.TabIndex = 26;
            this.lblImporte.Text = "Importe Total";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(184, 574);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(119, 26);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(355, 574);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 26);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(250, 190);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioProducto.TabIndex = 18;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // CrearFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 626);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.BoxPrecioProducto);
            this.Controls.Add(this.lblPrecioProducto);
            this.Controls.Add(this.BoxProducto);
            this.Controls.Add(this.lblProyecto);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.dataFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.NumFactura);
            this.Controls.Add(this.BoxCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.BoxTipoFact);
            this.Controls.Add(this.TipoFact);
            this.Name = "CrearFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear nueva factura";
            this.Load += new System.EventHandler(this.CrearFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TipoFact;
        private System.Windows.Forms.ComboBox BoxTipoFact;
        private System.Windows.Forms.ComboBox BoxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label NumFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dataFecha;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblProyecto;
        private System.Windows.Forms.ComboBox BoxProducto;
        private System.Windows.Forms.TextBox BoxPrecioProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblPrecioProducto;
    }
}