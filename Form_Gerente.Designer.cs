﻿namespace ATM
{
    partial class Form_Gerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Gerente));
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.finalizar_btn = new System.Windows.Forms.Button();
            this.nombre_lbl = new System.Windows.Forms.Label();
            this.nombre_tbx = new System.Windows.Forms.TextBox();
            this.apellidos_lbl = new System.Windows.Forms.Label();
            this.apellidos_tbx = new System.Windows.Forms.TextBox();
            this.usuario_lbl = new System.Windows.Forms.Label();
            this.usuario_tbx = new System.Windows.Forms.TextBox();
            this.contrasena_lbl = new System.Windows.Forms.Label();
            this.contrasena_tbx = new System.Windows.Forms.TextBox();
            this.titulo_lbl = new System.Windows.Forms.Label();
            this.rfc_lbl = new System.Windows.Forms.Label();
            this.clientes_dgv = new System.Windows.Forms.DataGridView();
            this.trabajadores_lbl = new System.Windows.Forms.Label();
            this.clientes_lbl = new System.Windows.Forms.Label();
            this.nacimiento_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Correo_lbl = new System.Windows.Forms.Label();
            this.correo_tbx = new System.Windows.Forms.TextBox();
            this.rfc_tbx = new System.Windows.Forms.TextBox();
            this.telefono_tbx = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Direccion_lbl = new System.Windows.Forms.Label();
            this.direccion_tbx = new System.Windows.Forms.TextBox();
            this.deposito_inicial_lbl = new System.Windows.Forms.Label();
            this.depo_ini_tbx = new System.Windows.Forms.TextBox();
            this.Administradores_dgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Administradores_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajeroToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // cajeroToolStripMenuItem
            // 
            this.cajeroToolStripMenuItem.Name = "cajeroToolStripMenuItem";
            this.cajeroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cajeroToolStripMenuItem.Text = "Cajero";
            this.cajeroToolStripMenuItem.Click += new System.EventHandler(this.cajeroToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem1,
            this.cajerosToolStripMenuItem});
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.eliminarToolStripMenuItem1.Text = "Clientes";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // cajerosToolStripMenuItem
            // 
            this.cajerosToolStripMenuItem.Name = "cajerosToolStripMenuItem";
            this.cajerosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cajerosToolStripMenuItem.Text = "Cajeros";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajadoresToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            this.trabajadoresToolStripMenuItem.Click += new System.EventHandler(this.trabajadoresToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem1});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.salirToolStripMenuItem.Text = "Salir?";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // finalizar_btn
            // 
            this.finalizar_btn.Location = new System.Drawing.Point(269, 399);
            this.finalizar_btn.Name = "finalizar_btn";
            this.finalizar_btn.Size = new System.Drawing.Size(82, 41);
            this.finalizar_btn.TabIndex = 16;
            this.finalizar_btn.UseVisualStyleBackColor = true;
            this.finalizar_btn.Visible = false;
            this.finalizar_btn.Click += new System.EventHandler(this.finalizar_btn_Click);
            // 
            // nombre_lbl
            // 
            this.nombre_lbl.AutoSize = true;
            this.nombre_lbl.Location = new System.Drawing.Point(13, 101);
            this.nombre_lbl.Name = "nombre_lbl";
            this.nombre_lbl.Size = new System.Drawing.Size(44, 13);
            this.nombre_lbl.TabIndex = 17;
            this.nombre_lbl.Text = "Nombre";
            this.nombre_lbl.Visible = false;
            // 
            // nombre_tbx
            // 
            this.nombre_tbx.Location = new System.Drawing.Point(16, 117);
            this.nombre_tbx.Name = "nombre_tbx";
            this.nombre_tbx.Size = new System.Drawing.Size(153, 20);
            this.nombre_tbx.TabIndex = 18;
            this.nombre_tbx.Visible = false;
            // 
            // apellidos_lbl
            // 
            this.apellidos_lbl.AutoSize = true;
            this.apellidos_lbl.Location = new System.Drawing.Point(196, 101);
            this.apellidos_lbl.Name = "apellidos_lbl";
            this.apellidos_lbl.Size = new System.Drawing.Size(49, 13);
            this.apellidos_lbl.TabIndex = 19;
            this.apellidos_lbl.Text = "Apellidos";
            this.apellidos_lbl.Visible = false;
            // 
            // apellidos_tbx
            // 
            this.apellidos_tbx.Location = new System.Drawing.Point(199, 117);
            this.apellidos_tbx.Name = "apellidos_tbx";
            this.apellidos_tbx.Size = new System.Drawing.Size(153, 20);
            this.apellidos_tbx.TabIndex = 20;
            this.apellidos_tbx.Visible = false;
            // 
            // usuario_lbl
            // 
            this.usuario_lbl.AutoSize = true;
            this.usuario_lbl.Location = new System.Drawing.Point(13, 153);
            this.usuario_lbl.Name = "usuario_lbl";
            this.usuario_lbl.Size = new System.Drawing.Size(96, 13);
            this.usuario_lbl.TabIndex = 21;
            this.usuario_lbl.Text = "Nombre de usuario";
            this.usuario_lbl.Visible = false;
            // 
            // usuario_tbx
            // 
            this.usuario_tbx.Location = new System.Drawing.Point(16, 169);
            this.usuario_tbx.Name = "usuario_tbx";
            this.usuario_tbx.Size = new System.Drawing.Size(153, 20);
            this.usuario_tbx.TabIndex = 22;
            this.usuario_tbx.Visible = false;
            // 
            // contrasena_lbl
            // 
            this.contrasena_lbl.AutoSize = true;
            this.contrasena_lbl.Location = new System.Drawing.Point(196, 153);
            this.contrasena_lbl.Name = "contrasena_lbl";
            this.contrasena_lbl.Size = new System.Drawing.Size(56, 13);
            this.contrasena_lbl.TabIndex = 23;
            this.contrasena_lbl.Text = "Contraeña";
            this.contrasena_lbl.Visible = false;
            // 
            // contrasena_tbx
            // 
            this.contrasena_tbx.Location = new System.Drawing.Point(199, 169);
            this.contrasena_tbx.Name = "contrasena_tbx";
            this.contrasena_tbx.Size = new System.Drawing.Size(153, 20);
            this.contrasena_tbx.TabIndex = 24;
            this.contrasena_tbx.Visible = false;
            // 
            // titulo_lbl
            // 
            this.titulo_lbl.AutoSize = true;
            this.titulo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_lbl.Location = new System.Drawing.Point(12, 45);
            this.titulo_lbl.Name = "titulo_lbl";
            this.titulo_lbl.Size = new System.Drawing.Size(58, 26);
            this.titulo_lbl.TabIndex = 25;
            this.titulo_lbl.Text = "titulo";
            // 
            // rfc_lbl
            // 
            this.rfc_lbl.AutoSize = true;
            this.rfc_lbl.Location = new System.Drawing.Point(14, 195);
            this.rfc_lbl.Name = "rfc_lbl";
            this.rfc_lbl.Size = new System.Drawing.Size(28, 13);
            this.rfc_lbl.TabIndex = 41;
            this.rfc_lbl.Text = "RFC";
            this.rfc_lbl.Visible = false;
            // 
            // clientes_dgv
            // 
            this.clientes_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientes_dgv.Location = new System.Drawing.Point(370, 283);
            this.clientes_dgv.Name = "clientes_dgv";
            this.clientes_dgv.Size = new System.Drawing.Size(418, 157);
            this.clientes_dgv.TabIndex = 27;
            this.clientes_dgv.Visible = false;
            // 
            // trabajadores_lbl
            // 
            this.trabajadores_lbl.AutoSize = true;
            this.trabajadores_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trabajadores_lbl.Location = new System.Drawing.Point(366, 56);
            this.trabajadores_lbl.Name = "trabajadores_lbl";
            this.trabajadores_lbl.Size = new System.Drawing.Size(102, 20);
            this.trabajadores_lbl.TabIndex = 28;
            this.trabajadores_lbl.Text = "Trabajadores";
            // 
            // clientes_lbl
            // 
            this.clientes_lbl.AutoSize = true;
            this.clientes_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientes_lbl.Location = new System.Drawing.Point(366, 260);
            this.clientes_lbl.Name = "clientes_lbl";
            this.clientes_lbl.Size = new System.Drawing.Size(66, 20);
            this.clientes_lbl.TabIndex = 29;
            this.clientes_lbl.Text = "Clientes";
            // 
            // nacimiento_lbl
            // 
            this.nacimiento_lbl.AutoSize = true;
            this.nacimiento_lbl.Location = new System.Drawing.Point(196, 195);
            this.nacimiento_lbl.Name = "nacimiento_lbl";
            this.nacimiento_lbl.Size = new System.Drawing.Size(108, 13);
            this.nacimiento_lbl.TabIndex = 30;
            this.nacimiento_lbl.Text = "Fecha de Nacimiento";
            this.nacimiento_lbl.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Telefono";
            this.label3.Visible = false;
            // 
            // Correo_lbl
            // 
            this.Correo_lbl.AutoSize = true;
            this.Correo_lbl.Location = new System.Drawing.Point(196, 246);
            this.Correo_lbl.Name = "Correo_lbl";
            this.Correo_lbl.Size = new System.Drawing.Size(38, 13);
            this.Correo_lbl.TabIndex = 32;
            this.Correo_lbl.Text = "Correo";
            this.Correo_lbl.Visible = false;
            // 
            // correo_tbx
            // 
            this.correo_tbx.Location = new System.Drawing.Point(198, 262);
            this.correo_tbx.Name = "correo_tbx";
            this.correo_tbx.Size = new System.Drawing.Size(153, 20);
            this.correo_tbx.TabIndex = 33;
            this.correo_tbx.Visible = false;
            // 
            // rfc_tbx
            // 
            this.rfc_tbx.Location = new System.Drawing.Point(17, 211);
            this.rfc_tbx.Name = "rfc_tbx";
            this.rfc_tbx.Size = new System.Drawing.Size(153, 20);
            this.rfc_tbx.TabIndex = 34;
            this.rfc_tbx.Visible = false;
            // 
            // telefono_tbx
            // 
            this.telefono_tbx.Location = new System.Drawing.Point(16, 262);
            this.telefono_tbx.Name = "telefono_tbx";
            this.telefono_tbx.Size = new System.Drawing.Size(153, 20);
            this.telefono_tbx.TabIndex = 35;
            this.telefono_tbx.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(198, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(152, 20);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.Visible = false;
            // 
            // Direccion_lbl
            // 
            this.Direccion_lbl.AutoSize = true;
            this.Direccion_lbl.Location = new System.Drawing.Point(14, 295);
            this.Direccion_lbl.Name = "Direccion_lbl";
            this.Direccion_lbl.Size = new System.Drawing.Size(52, 13);
            this.Direccion_lbl.TabIndex = 37;
            this.Direccion_lbl.Text = "Direccion";
            this.Direccion_lbl.Visible = false;
            // 
            // direccion_tbx
            // 
            this.direccion_tbx.Location = new System.Drawing.Point(17, 311);
            this.direccion_tbx.Name = "direccion_tbx";
            this.direccion_tbx.Size = new System.Drawing.Size(153, 20);
            this.direccion_tbx.TabIndex = 38;
            this.direccion_tbx.Visible = false;
            // 
            // deposito_inicial_lbl
            // 
            this.deposito_inicial_lbl.AutoSize = true;
            this.deposito_inicial_lbl.Location = new System.Drawing.Point(196, 295);
            this.deposito_inicial_lbl.Name = "deposito_inicial_lbl";
            this.deposito_inicial_lbl.Size = new System.Drawing.Size(79, 13);
            this.deposito_inicial_lbl.TabIndex = 39;
            this.deposito_inicial_lbl.Text = "Deposito Inicial";
            this.deposito_inicial_lbl.Visible = false;
            // 
            // depo_ini_tbx
            // 
            this.depo_ini_tbx.Location = new System.Drawing.Point(197, 311);
            this.depo_ini_tbx.Name = "depo_ini_tbx";
            this.depo_ini_tbx.Size = new System.Drawing.Size(153, 20);
            this.depo_ini_tbx.TabIndex = 40;
            this.depo_ini_tbx.Visible = false;
            // 
            // Administradores_dgv
            // 
            this.Administradores_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Administradores_dgv.Location = new System.Drawing.Point(370, 79);
            this.Administradores_dgv.Name = "Administradores_dgv";
            this.Administradores_dgv.Size = new System.Drawing.Size(418, 152);
            this.Administradores_dgv.TabIndex = 26;
            this.Administradores_dgv.Visible = false;
            // 
            // Form_Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.rfc_lbl);
            this.Controls.Add(this.depo_ini_tbx);
            this.Controls.Add(this.deposito_inicial_lbl);
            this.Controls.Add(this.direccion_tbx);
            this.Controls.Add(this.Direccion_lbl);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.telefono_tbx);
            this.Controls.Add(this.rfc_tbx);
            this.Controls.Add(this.correo_tbx);
            this.Controls.Add(this.Correo_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nacimiento_lbl);
            this.Controls.Add(this.clientes_lbl);
            this.Controls.Add(this.trabajadores_lbl);
            this.Controls.Add(this.clientes_dgv);
            this.Controls.Add(this.Administradores_dgv);
            this.Controls.Add(this.titulo_lbl);
            this.Controls.Add(this.contrasena_tbx);
            this.Controls.Add(this.contrasena_lbl);
            this.Controls.Add(this.usuario_tbx);
            this.Controls.Add(this.usuario_lbl);
            this.Controls.Add(this.apellidos_tbx);
            this.Controls.Add(this.apellidos_lbl);
            this.Controls.Add(this.nombre_tbx);
            this.Controls.Add(this.nombre_lbl);
            this.Controls.Add(this.finalizar_btn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Gerente";
            this.Text = "Gerente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientes_dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Administradores_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button finalizar_btn;
        private System.Windows.Forms.Label nombre_lbl;
        private System.Windows.Forms.TextBox nombre_tbx;
        private System.Windows.Forms.Label apellidos_lbl;
        private System.Windows.Forms.TextBox apellidos_tbx;
        private System.Windows.Forms.Label usuario_lbl;
        private System.Windows.Forms.TextBox usuario_tbx;
        private System.Windows.Forms.Label contrasena_lbl;
        private System.Windows.Forms.TextBox contrasena_tbx;
        private System.Windows.Forms.Label titulo_lbl;
        private System.Windows.Forms.Label rfc_lbl;
        private System.Windows.Forms.DataGridView clientes_dgv;
        private System.Windows.Forms.Label trabajadores_lbl;
        private System.Windows.Forms.Label clientes_lbl;
        private System.Windows.Forms.Label nacimiento_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Correo_lbl;
        private System.Windows.Forms.TextBox correo_tbx;
        private System.Windows.Forms.TextBox rfc_tbx;
        private System.Windows.Forms.TextBox telefono_tbx;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Direccion_lbl;
        private System.Windows.Forms.TextBox direccion_tbx;
        private System.Windows.Forms.Label deposito_inicial_lbl;
        private System.Windows.Forms.TextBox depo_ini_tbx;
        private System.Windows.Forms.DataGridView Administradores_dgv;
    }
}