namespace Facturación_de_proyectos_y_productos
{
    partial class CrearBarrio
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
            this.BoxBarrio = new System.Windows.Forms.TextBox();
            this.lblCrearBarrio = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BoxBarrio
            // 
            this.BoxBarrio.Location = new System.Drawing.Point(79, 105);
            this.BoxBarrio.Name = "BoxBarrio";
            this.BoxBarrio.Size = new System.Drawing.Size(232, 20);
            this.BoxBarrio.TabIndex = 0;
            // 
            // lblCrearBarrio
            // 
            this.lblCrearBarrio.AutoSize = true;
            this.lblCrearBarrio.Location = new System.Drawing.Point(121, 66);
            this.lblCrearBarrio.Name = "lblCrearBarrio";
            this.lblCrearBarrio.Size = new System.Drawing.Size(137, 13);
            this.lblCrearBarrio.TabIndex = 1;
            this.lblCrearBarrio.Text = "Ingrese el nombre del barrio";
            this.lblCrearBarrio.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(67, 165);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(113, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(214, 165);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CrearBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblCrearBarrio);
            this.Controls.Add(this.BoxBarrio);
            this.MinimizeBox = false;
            this.Name = "CrearBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Barrio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxBarrio;
        private System.Windows.Forms.Label lblCrearBarrio;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancel;
    }
}