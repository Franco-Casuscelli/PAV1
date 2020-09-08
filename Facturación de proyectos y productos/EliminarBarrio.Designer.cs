namespace Facturación_de_proyectos_y_productos
{
    partial class EliminarBarrio
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
            this.lblElmininar = new System.Windows.Forms.Label();
            this.BoxEliminarBarrio = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblElmininar
            // 
            this.lblElmininar.AutoSize = true;
            this.lblElmininar.Location = new System.Drawing.Point(98, 62);
            this.lblElmininar.Name = "lblElmininar";
            this.lblElmininar.Size = new System.Drawing.Size(184, 13);
            this.lblElmininar.TabIndex = 0;
            this.lblElmininar.Text = "Ingrese el nombre del barrio a eliminar";
            this.lblElmininar.Click += new System.EventHandler(this.label1_Click);
            // 
            // BoxEliminarBarrio
            // 
            this.BoxEliminarBarrio.Location = new System.Drawing.Point(101, 93);
            this.BoxEliminarBarrio.Name = "BoxEliminarBarrio";
            this.BoxEliminarBarrio.Size = new System.Drawing.Size(181, 20);
            this.BoxEliminarBarrio.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(85, 152);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(97, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(205, 152);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // EliminarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BoxEliminarBarrio);
            this.Controls.Add(this.lblElmininar);
            this.Name = "EliminarBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar Barrio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElmininar;
        private System.Windows.Forms.TextBox BoxEliminarBarrio;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
    }
}