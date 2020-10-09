namespace Facturación_de_proyectos_y_productos
{
    partial class CrearContacto
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
            this.BoxNombre = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.BoxApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.BoxUsuarioLogueado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BoxNombre
            // 
            this.BoxNombre.Location = new System.Drawing.Point(72, 78);
            this.BoxNombre.MaxLength = 50;
            this.BoxNombre.Name = "BoxNombre";
            this.BoxNombre.Size = new System.Drawing.Size(240, 20);
            this.BoxNombre.TabIndex = 8;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(69, 62);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(44, 13);
            this.lblRazonSocial.TabIndex = 7;
            this.lblRazonSocial.Text = "Nombre";
            // 
            // BoxApellido
            // 
            this.BoxApellido.Location = new System.Drawing.Point(72, 131);
            this.BoxApellido.MaxLength = 50;
            this.BoxApellido.Name = "BoxApellido";
            this.BoxApellido.Size = new System.Drawing.Size(240, 20);
            this.BoxApellido.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Apellido";
            // 
            // BoxTelefono
            // 
            this.BoxTelefono.Location = new System.Drawing.Point(72, 237);
            this.BoxTelefono.MaxLength = 50;
            this.BoxTelefono.Name = "BoxTelefono";
            this.BoxTelefono.Size = new System.Drawing.Size(240, 20);
            this.BoxTelefono.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Teléfono";
            // 
            // BoxEmail
            // 
            this.BoxEmail.Location = new System.Drawing.Point(72, 184);
            this.BoxEmail.MaxLength = 50;
            this.BoxEmail.Name = "BoxEmail";
            this.BoxEmail.Size = new System.Drawing.Size(240, 20);
            this.BoxEmail.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(224, 312);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(49, 312);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(113, 23);
            this.btnCrear.TabIndex = 15;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
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
            // 
            // CrearContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.BoxUsuarioLogueado);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.BoxTelefono);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxNombre);
            this.Controls.Add(this.lblRazonSocial);
            this.MaximizeBox = false;
            this.Name = "CrearContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Contactos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BoxNombre;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox BoxApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox BoxUsuarioLogueado;
    }
}