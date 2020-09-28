namespace Facturación_de_proyectos_y_productos
{
    partial class ModificarProyecto
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.BoxAlcance = new System.Windows.Forms.RichTextBox();
            this.BoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.BoxVersion = new System.Windows.Forms.TextBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 30);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Volver a la consulta";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(41, 281);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 30);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Guardar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // BoxAlcance
            // 
            this.BoxAlcance.Location = new System.Drawing.Point(70, 208);
            this.BoxAlcance.MaxLength = 50;
            this.BoxAlcance.Name = "BoxAlcance";
            this.BoxAlcance.Size = new System.Drawing.Size(240, 36);
            this.BoxAlcance.TabIndex = 19;
            this.BoxAlcance.Text = "";
            // 
            // BoxDescripcion
            // 
            this.BoxDescripcion.Location = new System.Drawing.Point(70, 70);
            this.BoxDescripcion.MaxLength = 50;
            this.BoxDescripcion.Name = "BoxDescripcion";
            this.BoxDescripcion.Size = new System.Drawing.Size(240, 36);
            this.BoxDescripcion.TabIndex = 18;
            this.BoxDescripcion.Text = "";
            // 
            // BoxVersion
            // 
            this.BoxVersion.Location = new System.Drawing.Point(70, 146);
            this.BoxVersion.MaxLength = 50;
            this.BoxVersion.Name = "BoxVersion";
            this.BoxVersion.Size = new System.Drawing.Size(240, 20);
            this.BoxVersion.TabIndex = 17;
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(67, 192);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(46, 13);
            this.lblAlcance.TabIndex = 16;
            this.lblAlcance.Text = "Alcance";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(67, 130);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "Version";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(67, 54);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción";
            // 
            // ModificarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.BoxAlcance);
            this.Controls.Add(this.BoxDescripcion);
            this.Controls.Add(this.BoxVersion);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDescripcion);
            this.MinimizeBox = false;
            this.Name = "ModificarProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Proyecto";
            this.Load += new System.EventHandler(this.ModificarProyecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.RichTextBox BoxAlcance;
        private System.Windows.Forms.RichTextBox BoxDescripcion;
        private System.Windows.Forms.TextBox BoxVersion;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}