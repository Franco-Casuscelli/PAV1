namespace Facturación_de_proyectos_y_productos
{
    partial class ConsultarBarrio
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarBarrio = new System.Windows.Forms.Label();
            this.TextConsultaBarrio = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFila = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(152, 111);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblBuscarBarrio
            // 
            this.lblBuscarBarrio.AutoSize = true;
            this.lblBuscarBarrio.Location = new System.Drawing.Point(101, 58);
            this.lblBuscarBarrio.Name = "lblBuscarBarrio";
            this.lblBuscarBarrio.Size = new System.Drawing.Size(126, 13);
            this.lblBuscarBarrio.TabIndex = 1;
            this.lblBuscarBarrio.Text = "Ingrese el barrio a buscar";
            this.lblBuscarBarrio.Click += new System.EventHandler(this.lblBuscarBarrio_Click);
            // 
            // TextConsultaBarrio
            // 
            this.TextConsultaBarrio.Location = new System.Drawing.Point(100, 74);
            this.TextConsultaBarrio.Name = "TextConsultaBarrio";
            this.TextConsultaBarrio.Size = new System.Drawing.Size(178, 20);
            this.TextConsultaBarrio.TabIndex = 2;
            this.TextConsultaBarrio.TextChanged += new System.EventHandler(this.TextConsultaBarrio_TextChanged);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(211, 347);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(123, 23);
            this.Return.TabIndex = 4;
            this.Return.Text = "Volver al menu";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 151);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(342, 174);
            this.dataGridView.TabIndex = 5;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(48, 347);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(123, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(18, 135);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(79, 13);
            this.lblFila.TabIndex = 7;
            this.lblFila.Text = "Seleccionar fila";
            // 
            // ConsultarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.lblFila);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.TextConsultaBarrio);
            this.Controls.Add(this.lblBuscarBarrio);
            this.Controls.Add(this.btnBuscar);
            this.MinimizeBox = false;
            this.Name = "ConsultarBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Barrios";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarBarrio;
        private System.Windows.Forms.TextBox TextConsultaBarrio;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblFila;
    }
}