namespace Facturación_de_proyectos_y_productos
{
    partial class ConsultarCliente
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
            this.lblCuitCliente = new System.Windows.Forms.Label();
            this.txtCuitConsulta = new System.Windows.Forms.TextBox();
            this.chbMostrarBorrado = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grillaCliente = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.BoxUsuarioLogueado = new System.Windows.Forms.TextBox();
            this.BoxFilas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCuitCliente
            // 
            this.lblCuitCliente.AutoSize = true;
            this.lblCuitCliente.Location = new System.Drawing.Point(130, 35);
            this.lblCuitCliente.Name = "lblCuitCliente";
            this.lblCuitCliente.Size = new System.Drawing.Size(124, 13);
            this.lblCuitCliente.TabIndex = 0;
            this.lblCuitCliente.Text = "Ingrese el cuit del cliente";
            // 
            // txtCuitConsulta
            // 
            this.txtCuitConsulta.Location = new System.Drawing.Point(114, 60);
            this.txtCuitConsulta.Name = "txtCuitConsulta";
            this.txtCuitConsulta.Size = new System.Drawing.Size(150, 20);
            this.txtCuitConsulta.TabIndex = 1;
            // 
            // chbMostrarBorrado
            // 
            this.chbMostrarBorrado.AutoSize = true;
            this.chbMostrarBorrado.Location = new System.Drawing.Point(114, 86);
            this.chbMostrarBorrado.Name = "chbMostrarBorrado";
            this.chbMostrarBorrado.Size = new System.Drawing.Size(105, 17);
            this.chbMostrarBorrado.TabIndex = 2;
            this.chbMostrarBorrado.Text = "Mostrar borrados";
            this.chbMostrarBorrado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(155, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // grillaCliente
            // 
            this.grillaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCliente.Location = new System.Drawing.Point(70, 171);
            this.grillaCliente.Name = "grillaCliente";
            this.grillaCliente.Size = new System.Drawing.Size(240, 150);
            this.grillaCliente.TabIndex = 4;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(48, 340);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(139, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(236, 340);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(93, 23);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "Volver al menu";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.Location = new System.Drawing.Point(67, 155);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(60, 13);
            this.lblSeleccion.TabIndex = 8;
            this.lblSeleccion.Text = "Seleccione";
            // 
            // BoxUsuarioLogueado
            // 
            this.BoxUsuarioLogueado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxUsuarioLogueado.Enabled = false;
            this.BoxUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUsuarioLogueado.Location = new System.Drawing.Point(9, 397);
            this.BoxUsuarioLogueado.Margin = new System.Windows.Forms.Padding(0);
            this.BoxUsuarioLogueado.MaxLength = 50;
            this.BoxUsuarioLogueado.Name = "BoxUsuarioLogueado";
            this.BoxUsuarioLogueado.Size = new System.Drawing.Size(120, 15);
            this.BoxUsuarioLogueado.TabIndex = 15;
            // 
            // BoxFilas
            // 
            this.BoxFilas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxFilas.Enabled = false;
            this.BoxFilas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxFilas.Location = new System.Drawing.Point(295, 155);
            this.BoxFilas.Margin = new System.Windows.Forms.Padding(0);
            this.BoxFilas.MaxLength = 50;
            this.BoxFilas.Name = "BoxFilas";
            this.BoxFilas.Size = new System.Drawing.Size(15, 15);
            this.BoxFilas.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filas:";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxFilas);
            this.Controls.Add(this.BoxUsuarioLogueado);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grillaCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.chbMostrarBorrado);
            this.Controls.Add(this.txtCuitConsulta);
            this.Controls.Add(this.lblCuitCliente);
            this.Name = "ConsultarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Cliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCuitCliente;
        private System.Windows.Forms.TextBox txtCuitConsulta;
        private System.Windows.Forms.CheckBox chbMostrarBorrado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grillaCliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.TextBox BoxUsuarioLogueado;
        private System.Windows.Forms.TextBox BoxFilas;
        private System.Windows.Forms.Label label1;
    }
}