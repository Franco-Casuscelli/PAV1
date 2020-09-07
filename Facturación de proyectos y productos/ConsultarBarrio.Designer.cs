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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxBarrios = new System.Windows.Forms.ListBox();
            this.Return = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 2;
            // 
            // listBoxBarrios
            // 
            this.listBoxBarrios.FormattingEnabled = true;
            this.listBoxBarrios.Location = new System.Drawing.Point(12, 162);
            this.listBoxBarrios.Name = "listBoxBarrios";
            this.listBoxBarrios.Size = new System.Drawing.Size(360, 134);
            this.listBoxBarrios.TabIndex = 3;
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(136, 346);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(123, 23);
            this.Return.TabIndex = 4;
            this.Return.Text = "Volver al menu";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // ConsultarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.listBoxBarrios);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblBuscarBarrio);
            this.Controls.Add(this.btnBuscar);
            this.Name = "ConsultarBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultar Barrios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscarBarrio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxBarrios;
        private System.Windows.Forms.Button Return;
    }
}