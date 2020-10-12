namespace Facturación_de_proyectos_y_productos
{
    partial class ModificarCliente
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
            this.BoxUsuarioLogueado = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblRazonSocial1 = new System.Windows.Forms.Label();
            this.lblCuit1 = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.txtRazonSocial1 = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtCuit1 = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.cmbContacto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BoxUsuarioLogueado
            // 
            this.BoxUsuarioLogueado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxUsuarioLogueado.Enabled = false;
            this.BoxUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUsuarioLogueado.Location = new System.Drawing.Point(9, 315);
            this.BoxUsuarioLogueado.Margin = new System.Windows.Forms.Padding(0);
            this.BoxUsuarioLogueado.MaxLength = 50;
            this.BoxUsuarioLogueado.Name = "BoxUsuarioLogueado";
            this.BoxUsuarioLogueado.Size = new System.Drawing.Size(120, 15);
            this.BoxUsuarioLogueado.TabIndex = 17;
            this.BoxUsuarioLogueado.TextChanged += new System.EventHandler(this.BoxUsuarioLogueado_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(85, 231);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 29);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 231);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 29);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblRazonSocial1
            // 
            this.lblRazonSocial1.AutoSize = true;
            this.lblRazonSocial1.Location = new System.Drawing.Point(40, 40);
            this.lblRazonSocial1.Name = "lblRazonSocial1";
            this.lblRazonSocial1.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial1.TabIndex = 0;
            this.lblRazonSocial1.Text = "Razon Social";
            // 
            // lblCuit1
            // 
            this.lblCuit1.AutoSize = true;
            this.lblCuit1.Location = new System.Drawing.Point(212, 40);
            this.lblCuit1.Name = "lblCuit1";
            this.lblCuit1.Size = new System.Drawing.Size(25, 13);
            this.lblCuit1.TabIndex = 1;
            this.lblCuit1.Text = "Cuit";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(40, 92);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(30, 13);
            this.lblCalle.TabIndex = 2;
            this.lblCalle.Text = "Calle";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(213, 92);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Numero";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(40, 147);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 4;
            this.lblBarrio.Text = "Barrio";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(213, 147);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 5;
            this.lblContacto.Text = "Contacto";
            this.lblContacto.Click += new System.EventHandler(this.lblContacto_Click);
            // 
            // txtRazonSocial1
            // 
            this.txtRazonSocial1.Location = new System.Drawing.Point(43, 56);
            this.txtRazonSocial1.MaxLength = 50;
            this.txtRazonSocial1.Name = "txtRazonSocial1";
            this.txtRazonSocial1.Size = new System.Drawing.Size(136, 20);
            this.txtRazonSocial1.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(217, 108);
            this.txtNumero.MaxLength = 50;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(135, 20);
            this.txtNumero.TabIndex = 7;
            // 
            // txtCuit1
            // 
            this.txtCuit1.Location = new System.Drawing.Point(215, 56);
            this.txtCuit1.MaxLength = 50;
            this.txtCuit1.Name = "txtCuit1";
            this.txtCuit1.Size = new System.Drawing.Size(136, 20);
            this.txtCuit1.TabIndex = 8;
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(43, 108);
            this.txtCalle.MaxLength = 50;
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(136, 20);
            this.txtCalle.TabIndex = 9;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(43, 163);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(136, 21);
            this.cmbBarrio.TabIndex = 10;
            // 
            // cmbContacto
            // 
            this.cmbContacto.FormattingEnabled = true;
            this.cmbContacto.Location = new System.Drawing.Point(215, 163);
            this.cmbContacto.Name = "cmbContacto";
            this.cmbContacto.Size = new System.Drawing.Size(136, 21);
            this.cmbContacto.TabIndex = 11;
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 331);
            this.Controls.Add(this.BoxUsuarioLogueado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.cmbContacto);
            this.Controls.Add(this.cmbBarrio);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtCuit1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtRazonSocial1);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.lblCuit1);
            this.Controls.Add(this.lblRazonSocial1);
            this.MaximizeBox = false;
            this.Name = "ModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Modificar Cliente";
            this.Load += new System.EventHandler(this.ModificarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox BoxUsuarioLogueado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblRazonSocial1;
        private System.Windows.Forms.Label lblCuit1;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.TextBox txtRazonSocial1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtCuit1;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.ComboBox cmbContacto;
    }
}