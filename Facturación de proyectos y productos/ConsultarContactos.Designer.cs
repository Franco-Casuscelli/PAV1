namespace Facturación_de_proyectos_y_productos
{
    partial class ConsultarContactos
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
            this.label1 = new System.Windows.Forms.Label();
            this.BoxFilas = new System.Windows.Forms.TextBox();
            this.BoxUsuarioLogueado = new System.Windows.Forms.TextBox();
            this.CheckListado = new System.Windows.Forms.CheckBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.lblFila = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Return = new System.Windows.Forms.Button();
            this.BoxApellido = new System.Windows.Forms.TextBox();
            this.lblBuscarBarrio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filas:";
            // 
            // BoxFilas
            // 
            this.BoxFilas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxFilas.Enabled = false;
            this.BoxFilas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxFilas.Location = new System.Drawing.Point(316, 134);
            this.BoxFilas.Margin = new System.Windows.Forms.Padding(0);
            this.BoxFilas.MaxLength = 50;
            this.BoxFilas.Name = "BoxFilas";
            this.BoxFilas.Size = new System.Drawing.Size(15, 15);
            this.BoxFilas.TabIndex = 30;
            // 
            // BoxUsuarioLogueado
            // 
            this.BoxUsuarioLogueado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxUsuarioLogueado.Enabled = false;
            this.BoxUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUsuarioLogueado.Location = new System.Drawing.Point(9, 395);
            this.BoxUsuarioLogueado.Margin = new System.Windows.Forms.Padding(0);
            this.BoxUsuarioLogueado.MaxLength = 50;
            this.BoxUsuarioLogueado.Name = "BoxUsuarioLogueado";
            this.BoxUsuarioLogueado.Size = new System.Drawing.Size(110, 16);
            this.BoxUsuarioLogueado.TabIndex = 29;
            // 
            // CheckListado
            // 
            this.CheckListado.AutoSize = true;
            this.CheckListado.Location = new System.Drawing.Point(100, 73);
            this.CheckListado.Name = "CheckListado";
            this.CheckListado.Size = new System.Drawing.Size(106, 17);
            this.CheckListado.TabIndex = 28;
            this.CheckListado.Text = "Mostrar Borrados";
            this.CheckListado.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(139, 346);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(101, 23);
            this.BtnEliminar.TabIndex = 27;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(45, 134);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(79, 13);
            this.lblFila.TabIndex = 26;
            this.lblFila.Text = "Seleccionar fila";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(32, 346);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 23);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(48, 150);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(283, 174);
            this.dataGridView.TabIndex = 24;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(246, 346);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(101, 23);
            this.Return.TabIndex = 23;
            this.Return.Text = "Volver al menu";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // BoxApellido
            // 
            this.BoxApellido.Location = new System.Drawing.Point(100, 47);
            this.BoxApellido.Name = "BoxApellido";
            this.BoxApellido.Size = new System.Drawing.Size(178, 20);
            this.BoxApellido.TabIndex = 22;
            // 
            // lblBuscarBarrio
            // 
            this.lblBuscarBarrio.AutoSize = true;
            this.lblBuscarBarrio.Location = new System.Drawing.Point(121, 31);
            this.lblBuscarBarrio.Name = "lblBuscarBarrio";
            this.lblBuscarBarrio.Size = new System.Drawing.Size(136, 13);
            this.lblBuscarBarrio.TabIndex = 21;
            this.lblBuscarBarrio.Text = "Ingrese el apellido a buscar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(148, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ConsultarContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxFilas);
            this.Controls.Add(this.BoxUsuarioLogueado);
            this.Controls.Add(this.CheckListado);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.lblFila);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.BoxApellido);
            this.Controls.Add(this.lblBuscarBarrio);
            this.Controls.Add(this.btnBuscar);
            this.MinimizeBox = false;
            this.Name = "ConsultarContactos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Contactos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxFilas;
        private System.Windows.Forms.TextBox BoxUsuarioLogueado;
        private System.Windows.Forms.CheckBox CheckListado;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.TextBox BoxApellido;
        private System.Windows.Forms.Label lblBuscarBarrio;
        private System.Windows.Forms.Button btnBuscar;
    }
}