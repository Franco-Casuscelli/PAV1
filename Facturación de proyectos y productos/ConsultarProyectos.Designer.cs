namespace Facturación_de_proyectos_y_productos
{
    partial class ConsultarProyectos
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
            this.CheckListado = new System.Windows.Forms.CheckBox();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.lblFila = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Return = new System.Windows.Forms.Button();
            this.lblBuscarBProyecto = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.BoxProducto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckListado
            // 
            this.CheckListado.AutoSize = true;
            this.CheckListado.Location = new System.Drawing.Point(106, 78);
            this.CheckListado.Name = "CheckListado";
            this.CheckListado.Size = new System.Drawing.Size(106, 17);
            this.CheckListado.TabIndex = 18;
            this.CheckListado.Text = "Mostrar Borrados";
            this.CheckListado.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(139, 351);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(101, 23);
            this.BtnEliminar.TabIndex = 17;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(9, 139);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(79, 13);
            this.lblFila.TabIndex = 16;
            this.lblFila.Text = "Seleccionar fila";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(32, 351);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 155);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(360, 174);
            this.dataGridView.TabIndex = 14;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(246, 351);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(101, 23);
            this.Return.TabIndex = 13;
            this.Return.Text = "Volver al menu";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // lblBuscarBProyecto
            // 
            this.lblBuscarBProyecto.AutoSize = true;
            this.lblBuscarBProyecto.Location = new System.Drawing.Point(136, 36);
            this.lblBuscarBProyecto.Name = "lblBuscarBProyecto";
            this.lblBuscarBProyecto.Size = new System.Drawing.Size(120, 13);
            this.lblBuscarBProyecto.TabIndex = 11;
            this.lblBuscarBProyecto.Text = "Seleccione un producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(155, 101);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // BoxProducto
            // 
            this.BoxProducto.FormattingEnabled = true;
            this.BoxProducto.Location = new System.Drawing.Point(106, 52);
            this.BoxProducto.MaxLength = 50;
            this.BoxProducto.Name = "BoxProducto";
            this.BoxProducto.Size = new System.Drawing.Size(178, 21);
            this.BoxProducto.TabIndex = 19;
            // 
            // ConsultarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.BoxProducto);
            this.Controls.Add(this.CheckListado);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.lblFila);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.lblBuscarBProyecto);
            this.Controls.Add(this.btnBuscar);
            this.MinimizeBox = false;
            this.Name = "ConsultarProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckListado;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.Label lblBuscarBProyecto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox BoxProducto;
    }
}