namespace Facturación_de_proyectos_y_productos
{
    partial class CrearProyecto
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
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.BoxProducto = new System.Windows.Forms.ComboBox();
            this.lblAlcance = new System.Windows.Forms.Label();
            this.BoxVersion = new System.Windows.Forms.TextBox();
            this.BoxResponsable = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BoxAlcance = new System.Windows.Forms.RichTextBox();
            this.BoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(70, 44);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(70, 123);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(70, 199);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Version";
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(70, 84);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(69, 13);
            this.lblResponsable.TabIndex = 3;
            this.lblResponsable.Text = "Responsable";
            // 
            // BoxProducto
            // 
            this.BoxProducto.FormattingEnabled = true;
            this.BoxProducto.Location = new System.Drawing.Point(145, 41);
            this.BoxProducto.Name = "BoxProducto";
            this.BoxProducto.Size = new System.Drawing.Size(168, 21);
            this.BoxProducto.TabIndex = 4;
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(70, 261);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(46, 13);
            this.lblAlcance.TabIndex = 6;
            this.lblAlcance.Text = "Alcance";
            // 
            // BoxVersion
            // 
            this.BoxVersion.Location = new System.Drawing.Point(73, 215);
            this.BoxVersion.MaxLength = 50;
            this.BoxVersion.Name = "BoxVersion";
            this.BoxVersion.Size = new System.Drawing.Size(240, 20);
            this.BoxVersion.TabIndex = 7;
            // 
            // BoxResponsable
            // 
            this.BoxResponsable.FormattingEnabled = true;
            this.BoxResponsable.Location = new System.Drawing.Point(145, 81);
            this.BoxResponsable.Name = "BoxResponsable";
            this.BoxResponsable.Size = new System.Drawing.Size(168, 21);
            this.BoxResponsable.TabIndex = 9;
            this.BoxResponsable.SelectedIndexChanged += new System.EventHandler(this.BoxResponsable_SelectedIndexChanged);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(44, 350);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(119, 30);
            this.btnCrear.TabIndex = 12;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(225, 350);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 30);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BoxAlcance
            // 
            this.BoxAlcance.Location = new System.Drawing.Point(73, 277);
            this.BoxAlcance.MaxLength = 50;
            this.BoxAlcance.Name = "BoxAlcance";
            this.BoxAlcance.Size = new System.Drawing.Size(240, 36);
            this.BoxAlcance.TabIndex = 11;
            this.BoxAlcance.Text = "";
            // 
            // BoxDescripcion
            // 
            this.BoxDescripcion.Location = new System.Drawing.Point(73, 139);
            this.BoxDescripcion.MaxLength = 50;
            this.BoxDescripcion.Name = "BoxDescripcion";
            this.BoxDescripcion.Size = new System.Drawing.Size(240, 36);
            this.BoxDescripcion.TabIndex = 10;
            this.BoxDescripcion.Text = "";
            this.BoxDescripcion.TextChanged += new System.EventHandler(this.BoxDescripcion_TextChanged);
            // 
            // CrearProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.BoxAlcance);
            this.Controls.Add(this.BoxDescripcion);
            this.Controls.Add(this.BoxResponsable);
            this.Controls.Add(this.BoxVersion);
            this.Controls.Add(this.lblAlcance);
            this.Controls.Add(this.BoxProducto);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblProducto);
            this.MaximizeBox = false;
            this.Name = "CrearProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Proyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.ComboBox BoxProducto;
        private System.Windows.Forms.Label lblAlcance;
        private System.Windows.Forms.TextBox BoxVersion;
        private System.Windows.Forms.ComboBox BoxResponsable;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RichTextBox BoxAlcance;
        private System.Windows.Forms.RichTextBox BoxDescripcion;
    }
}