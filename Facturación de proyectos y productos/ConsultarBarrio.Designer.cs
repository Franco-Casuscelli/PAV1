﻿namespace Facturación_de_proyectos_y_productos
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
            this.components = new System.ComponentModel.Container();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarBarrio = new System.Windows.Forms.Label();
            this.TextConsultaBarrio = new System.Windows.Forms.TextBox();
            this.Return = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFila = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.CheckListado = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.BoxUsuarioLogueado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxFilas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(152, 97);
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
            this.lblBuscarBarrio.Location = new System.Drawing.Point(130, 32);
            this.lblBuscarBarrio.Name = "lblBuscarBarrio";
            this.lblBuscarBarrio.Size = new System.Drawing.Size(126, 13);
            this.lblBuscarBarrio.TabIndex = 1;
            this.lblBuscarBarrio.Text = "Ingrese el barrio a buscar";
            this.lblBuscarBarrio.Click += new System.EventHandler(this.lblBuscarBarrio_Click);
            // 
            // TextConsultaBarrio
            // 
            this.TextConsultaBarrio.Location = new System.Drawing.Point(104, 48);
            this.TextConsultaBarrio.Name = "TextConsultaBarrio";
            this.TextConsultaBarrio.Size = new System.Drawing.Size(178, 20);
            this.TextConsultaBarrio.TabIndex = 2;
            this.TextConsultaBarrio.TextChanged += new System.EventHandler(this.TextConsultaBarrio_TextChanged);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(250, 347);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(101, 23);
            this.Return.TabIndex = 4;
            this.Return.Text = "Volver al menu";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(52, 151);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(283, 174);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(36, 347);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(101, 23);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar ";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(49, 135);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(79, 13);
            this.lblFila.TabIndex = 7;
            this.lblFila.Text = "Seleccionar fila";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(143, 347);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(101, 23);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // CheckListado
            // 
            this.CheckListado.AutoSize = true;
            this.CheckListado.Location = new System.Drawing.Point(104, 74);
            this.CheckListado.Name = "CheckListado";
            this.CheckListado.Size = new System.Drawing.Size(106, 17);
            this.CheckListado.TabIndex = 9;
            this.CheckListado.Text = "Mostrar Borrados";
            this.CheckListado.UseVisualStyleBackColor = true;
            this.CheckListado.CheckedChanged += new System.EventHandler(this.CheckListado_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // BoxUsuarioLogueado
            // 
            this.BoxUsuarioLogueado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxUsuarioLogueado.Enabled = false;
            this.BoxUsuarioLogueado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxUsuarioLogueado.Location = new System.Drawing.Point(9, 395);
            this.BoxUsuarioLogueado.Margin = new System.Windows.Forms.Padding(0);
            this.BoxUsuarioLogueado.MaxLength = 50;
            this.BoxUsuarioLogueado.Name = "BoxUsuarioLogueado";
            this.BoxUsuarioLogueado.Size = new System.Drawing.Size(110, 16);
            this.BoxUsuarioLogueado.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filas:";
            // 
            // BoxFilas
            // 
            this.BoxFilas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxFilas.Enabled = false;
            this.BoxFilas.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxFilas.Location = new System.Drawing.Point(320, 135);
            this.BoxFilas.Margin = new System.Windows.Forms.Padding(0);
            this.BoxFilas.MaxLength = 50;
            this.BoxFilas.Name = "BoxFilas";
            this.BoxFilas.Size = new System.Drawing.Size(15, 15);
            this.BoxFilas.TabIndex = 18;
            // 
            // ConsultarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxFilas);
            this.Controls.Add(this.BoxUsuarioLogueado);
            this.Controls.Add(this.CheckListado);
            this.Controls.Add(this.BtnEliminar);
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
            this.Load += new System.EventHandler(this.ConsultarBarrio_Load);
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
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.CheckBox CheckListado;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox BoxUsuarioLogueado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BoxFilas;
    }
}