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
            this.BoxUsuarioLogueado = new System.Windows.Forms.TextBox();
            this.lblResponsable = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.BoxProducto = new System.Windows.Forms.TextBox();
            this.boxRespondable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(222, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 30);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Volver a la consulta";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(41, 330);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(119, 30);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Guardar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // BoxAlcance
            // 
            this.BoxAlcance.Location = new System.Drawing.Point(70, 266);
            this.BoxAlcance.MaxLength = 50;
            this.BoxAlcance.Name = "BoxAlcance";
            this.BoxAlcance.Size = new System.Drawing.Size(240, 36);
            this.BoxAlcance.TabIndex = 19;
            this.BoxAlcance.Text = "";
            // 
            // BoxDescripcion
            // 
            this.BoxDescripcion.Location = new System.Drawing.Point(70, 128);
            this.BoxDescripcion.MaxLength = 50;
            this.BoxDescripcion.Name = "BoxDescripcion";
            this.BoxDescripcion.Size = new System.Drawing.Size(240, 36);
            this.BoxDescripcion.TabIndex = 18;
            this.BoxDescripcion.Text = "";
            // 
            // BoxVersion
            // 
            this.BoxVersion.Location = new System.Drawing.Point(70, 204);
            this.BoxVersion.MaxLength = 50;
            this.BoxVersion.Name = "BoxVersion";
            this.BoxVersion.Size = new System.Drawing.Size(240, 20);
            this.BoxVersion.TabIndex = 17;
            // 
            // lblAlcance
            // 
            this.lblAlcance.AutoSize = true;
            this.lblAlcance.Location = new System.Drawing.Point(67, 250);
            this.lblAlcance.Name = "lblAlcance";
            this.lblAlcance.Size = new System.Drawing.Size(46, 13);
            this.lblAlcance.TabIndex = 16;
            this.lblAlcance.Text = "Alcance";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(67, 188);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 15;
            this.lblVersion.Text = "Version";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(67, 112);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 14;
            this.lblDescripcion.Text = "Descripción";
            // 
            // BoxUsuarioLogueado
            // 
            this.BoxUsuarioLogueado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxUsuarioLogueado.Enabled = false;
            this.BoxUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUsuarioLogueado.Location = new System.Drawing.Point(9, 396);
            this.BoxUsuarioLogueado.Margin = new System.Windows.Forms.Padding(0);
            this.BoxUsuarioLogueado.MaxLength = 50;
            this.BoxUsuarioLogueado.Name = "BoxUsuarioLogueado";
            this.BoxUsuarioLogueado.Size = new System.Drawing.Size(120, 15);
            this.BoxUsuarioLogueado.TabIndex = 22;
            this.BoxUsuarioLogueado.TextChanged += new System.EventHandler(this.BoxUsuarioLogueado_TextChanged);
            // 
            // lblResponsable
            // 
            this.lblResponsable.AutoSize = true;
            this.lblResponsable.Location = new System.Drawing.Point(67, 69);
            this.lblResponsable.Name = "lblResponsable";
            this.lblResponsable.Size = new System.Drawing.Size(69, 13);
            this.lblResponsable.TabIndex = 24;
            this.lblResponsable.Text = "Responsable";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(67, 29);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 23;
            this.lblProducto.Text = "Producto";
            // 
            // BoxProducto
            // 
            this.BoxProducto.Location = new System.Drawing.Point(142, 26);
            this.BoxProducto.MaxLength = 50;
            this.BoxProducto.Name = "BoxProducto";
            this.BoxProducto.Size = new System.Drawing.Size(168, 20);
            this.BoxProducto.TabIndex = 27;
            // 
            // boxRespondable
            // 
            this.boxRespondable.Location = new System.Drawing.Point(142, 66);
            this.boxRespondable.MaxLength = 50;
            this.boxRespondable.Name = "boxRespondable";
            this.boxRespondable.Size = new System.Drawing.Size(168, 20);
            this.boxRespondable.TabIndex = 28;
            // 
            // ModificarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.boxRespondable);
            this.Controls.Add(this.BoxProducto);
            this.Controls.Add(this.lblResponsable);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.BoxUsuarioLogueado);
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
        private System.Windows.Forms.TextBox BoxUsuarioLogueado;
        private System.Windows.Forms.Label lblResponsable;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox BoxProducto;
        private System.Windows.Forms.TextBox boxRespondable;
    }
}