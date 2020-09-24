namespace Facturación_de_proyectos_y_productos
{
    partial class ModificarBarrio
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
            this.lblModificarBarrio = new System.Windows.Forms.Label();
            this.BoxBarrio = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblModificarBarrio
            // 
            this.lblModificarBarrio.AutoSize = true;
            this.lblModificarBarrio.Location = new System.Drawing.Point(119, 66);
            this.lblModificarBarrio.Name = "lblModificarBarrio";
            this.lblModificarBarrio.Size = new System.Drawing.Size(148, 13);
            this.lblModificarBarrio.TabIndex = 3;
            this.lblModificarBarrio.Text = "Modifique el nombre del barrio";
            this.lblModificarBarrio.Click += new System.EventHandler(this.lblCrearBarrio_Click);
            // 
            // BoxBarrio
            // 
            this.BoxBarrio.Location = new System.Drawing.Point(81, 98);
            this.BoxBarrio.MaxLength = 50;
            this.BoxBarrio.Name = "BoxBarrio";
            this.BoxBarrio.Size = new System.Drawing.Size(226, 20);
            this.BoxBarrio.TabIndex = 2;
            this.BoxBarrio.TextChanged += new System.EventHandler(this.BoxBarrio_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(52, 157);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Guardar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(211, 157);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(123, 23);
            this.Return.TabIndex = 5;
            this.Return.Text = "Volver al menu";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // ModificarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblModificarBarrio);
            this.Controls.Add(this.BoxBarrio);
            this.MinimizeBox = false;
            this.Name = "ModificarBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Barrio";
            this.Load += new System.EventHandler(this.ModificarBarrio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificarBarrio;
        private System.Windows.Forms.TextBox BoxBarrio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button Return;
    }
}