namespace ATM
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.LBL_FechaNaci_Cliente = new System.Windows.Forms.Label();
            this.LBL_RFC = new System.Windows.Forms.Label();
            this.LBL_Nombre_Cliente = new System.Windows.Forms.Label();
            this.LBl_Registro_Cliente = new System.Windows.Forms.Label();
            this.LBL_Apellidos_Clientes = new System.Windows.Forms.Label();
            this.LBL_Direccion_Cliente = new System.Windows.Forms.Label();
            this.LBl_Correo = new System.Windows.Forms.Label();
            this.LBL_Telefono_Cliente = new System.Windows.Forms.Label();
            this.TBX_Nombre_Cliente = new System.Windows.Forms.TextBox();
            this.TBX_Apellidos_Cliente = new System.Windows.Forms.TextBox();
            this.TBX_RFC = new System.Windows.Forms.TextBox();
            this.TBX_FechaNaci_Cliente = new System.Windows.Forms.TextBox();
            this.TBX_Direccion_Cliente = new System.Windows.Forms.TextBox();
            this.TBX_Telefon_Cliente = new System.Windows.Forms.TextBox();
            this.TBX_Correo_Cliente = new System.Windows.Forms.TextBox();
            this.BTN_Agregar_Cliente = new System.Windows.Forms.Button();
            this.GBX_Registrar = new System.Windows.Forms.GroupBox();
            this.GBX_Asignar = new System.Windows.Forms.GroupBox();
            this.LBL_IDCliente_Cuenta = new System.Windows.Forms.Label();
            this.BTN_Asignar_Cuenta = new System.Windows.Forms.Button();
            this.LBL_Contraseña_Cuenta = new System.Windows.Forms.Label();
            this.LBL_Usuario_Cuenta = new System.Windows.Forms.Label();
            this.LBL_Asignacion_Cuenta = new System.Windows.Forms.Label();
            this.TBX_Contraseña_Cuenta = new System.Windows.Forms.TextBox();
            this.TBX_Usuario_Cuenta = new System.Windows.Forms.TextBox();
            this.TBX_CL_ID = new System.Windows.Forms.TextBox();
            this.crearCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.GBX_Registrar.SuspendLayout();
            this.GBX_Asignar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCuentaToolStripMenuItem,
            this.asignarCuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LBL_FechaNaci_Cliente
            // 
            this.LBL_FechaNaci_Cliente.AutoSize = true;
            this.LBL_FechaNaci_Cliente.Location = new System.Drawing.Point(24, 136);
            this.LBL_FechaNaci_Cliente.Name = "LBL_FechaNaci_Cliente";
            this.LBL_FechaNaci_Cliente.Size = new System.Drawing.Size(110, 13);
            this.LBL_FechaNaci_Cliente.TabIndex = 1;
            this.LBL_FechaNaci_Cliente.Text = "Fecha De Nacimiento";
            // 
            // LBL_RFC
            // 
            this.LBL_RFC.AutoSize = true;
            this.LBL_RFC.Location = new System.Drawing.Point(24, 110);
            this.LBL_RFC.Name = "LBL_RFC";
            this.LBL_RFC.Size = new System.Drawing.Size(28, 13);
            this.LBL_RFC.TabIndex = 2;
            this.LBL_RFC.Text = "RFC";
            // 
            // LBL_Nombre_Cliente
            // 
            this.LBL_Nombre_Cliente.AutoSize = true;
            this.LBL_Nombre_Cliente.Location = new System.Drawing.Point(24, 58);
            this.LBL_Nombre_Cliente.Name = "LBL_Nombre_Cliente";
            this.LBL_Nombre_Cliente.Size = new System.Drawing.Size(44, 13);
            this.LBL_Nombre_Cliente.TabIndex = 3;
            this.LBL_Nombre_Cliente.Text = "Nombre";
            // 
            // LBl_Registro_Cliente
            // 
            this.LBl_Registro_Cliente.AutoSize = true;
            this.LBl_Registro_Cliente.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBl_Registro_Cliente.Location = new System.Drawing.Point(68, 16);
            this.LBl_Registro_Cliente.Name = "LBl_Registro_Cliente";
            this.LBl_Registro_Cliente.Size = new System.Drawing.Size(170, 22);
            this.LBl_Registro_Cliente.TabIndex = 4;
            this.LBl_Registro_Cliente.Text = "Registro de clientes";
            // 
            // LBL_Apellidos_Clientes
            // 
            this.LBL_Apellidos_Clientes.AutoSize = true;
            this.LBL_Apellidos_Clientes.Location = new System.Drawing.Point(24, 84);
            this.LBL_Apellidos_Clientes.Name = "LBL_Apellidos_Clientes";
            this.LBL_Apellidos_Clientes.Size = new System.Drawing.Size(49, 13);
            this.LBL_Apellidos_Clientes.TabIndex = 5;
            this.LBL_Apellidos_Clientes.Text = "Apellidos";
            // 
            // LBL_Direccion_Cliente
            // 
            this.LBL_Direccion_Cliente.AutoSize = true;
            this.LBL_Direccion_Cliente.Location = new System.Drawing.Point(24, 162);
            this.LBL_Direccion_Cliente.Name = "LBL_Direccion_Cliente";
            this.LBL_Direccion_Cliente.Size = new System.Drawing.Size(52, 13);
            this.LBL_Direccion_Cliente.TabIndex = 6;
            this.LBL_Direccion_Cliente.Text = "Dirección";
            // 
            // LBl_Correo
            // 
            this.LBl_Correo.AutoSize = true;
            this.LBl_Correo.Location = new System.Drawing.Point(24, 214);
            this.LBl_Correo.Name = "LBl_Correo";
            this.LBl_Correo.Size = new System.Drawing.Size(38, 13);
            this.LBl_Correo.TabIndex = 7;
            this.LBl_Correo.Text = "Correo";
            // 
            // LBL_Telefono_Cliente
            // 
            this.LBL_Telefono_Cliente.AutoSize = true;
            this.LBL_Telefono_Cliente.Location = new System.Drawing.Point(24, 188);
            this.LBL_Telefono_Cliente.Name = "LBL_Telefono_Cliente";
            this.LBL_Telefono_Cliente.Size = new System.Drawing.Size(49, 13);
            this.LBL_Telefono_Cliente.TabIndex = 8;
            this.LBL_Telefono_Cliente.Text = "Telefono";
            // 
            // TBX_Nombre_Cliente
            // 
            this.TBX_Nombre_Cliente.Location = new System.Drawing.Point(140, 58);
            this.TBX_Nombre_Cliente.Name = "TBX_Nombre_Cliente";
            this.TBX_Nombre_Cliente.Size = new System.Drawing.Size(146, 20);
            this.TBX_Nombre_Cliente.TabIndex = 10;
            // 
            // TBX_Apellidos_Cliente
            // 
            this.TBX_Apellidos_Cliente.Location = new System.Drawing.Point(140, 84);
            this.TBX_Apellidos_Cliente.Name = "TBX_Apellidos_Cliente";
            this.TBX_Apellidos_Cliente.Size = new System.Drawing.Size(146, 20);
            this.TBX_Apellidos_Cliente.TabIndex = 11;
            // 
            // TBX_RFC
            // 
            this.TBX_RFC.Location = new System.Drawing.Point(140, 110);
            this.TBX_RFC.Name = "TBX_RFC";
            this.TBX_RFC.Size = new System.Drawing.Size(146, 20);
            this.TBX_RFC.TabIndex = 12;
            // 
            // TBX_FechaNaci_Cliente
            // 
            this.TBX_FechaNaci_Cliente.Location = new System.Drawing.Point(140, 136);
            this.TBX_FechaNaci_Cliente.Name = "TBX_FechaNaci_Cliente";
            this.TBX_FechaNaci_Cliente.Size = new System.Drawing.Size(146, 20);
            this.TBX_FechaNaci_Cliente.TabIndex = 13;
            // 
            // TBX_Direccion_Cliente
            // 
            this.TBX_Direccion_Cliente.Location = new System.Drawing.Point(140, 162);
            this.TBX_Direccion_Cliente.Name = "TBX_Direccion_Cliente";
            this.TBX_Direccion_Cliente.Size = new System.Drawing.Size(146, 20);
            this.TBX_Direccion_Cliente.TabIndex = 14;
            // 
            // TBX_Telefon_Cliente
            // 
            this.TBX_Telefon_Cliente.Location = new System.Drawing.Point(140, 188);
            this.TBX_Telefon_Cliente.Name = "TBX_Telefon_Cliente";
            this.TBX_Telefon_Cliente.Size = new System.Drawing.Size(146, 20);
            this.TBX_Telefon_Cliente.TabIndex = 15;
            // 
            // TBX_Correo_Cliente
            // 
            this.TBX_Correo_Cliente.Location = new System.Drawing.Point(140, 214);
            this.TBX_Correo_Cliente.Name = "TBX_Correo_Cliente";
            this.TBX_Correo_Cliente.Size = new System.Drawing.Size(146, 20);
            this.TBX_Correo_Cliente.TabIndex = 16;
            // 
            // BTN_Agregar_Cliente
            // 
            this.BTN_Agregar_Cliente.Location = new System.Drawing.Point(124, 263);
            this.BTN_Agregar_Cliente.Name = "BTN_Agregar_Cliente";
            this.BTN_Agregar_Cliente.Size = new System.Drawing.Size(75, 23);
            this.BTN_Agregar_Cliente.TabIndex = 17;
            this.BTN_Agregar_Cliente.Text = "Agregar";
            this.BTN_Agregar_Cliente.UseVisualStyleBackColor = true;
            this.BTN_Agregar_Cliente.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // GBX_Registrar
            // 
            this.GBX_Registrar.Controls.Add(this.LBL_Nombre_Cliente);
            this.GBX_Registrar.Controls.Add(this.BTN_Agregar_Cliente);
            this.GBX_Registrar.Controls.Add(this.LBL_FechaNaci_Cliente);
            this.GBX_Registrar.Controls.Add(this.TBX_Correo_Cliente);
            this.GBX_Registrar.Controls.Add(this.LBL_RFC);
            this.GBX_Registrar.Controls.Add(this.TBX_Telefon_Cliente);
            this.GBX_Registrar.Controls.Add(this.LBl_Registro_Cliente);
            this.GBX_Registrar.Controls.Add(this.TBX_Direccion_Cliente);
            this.GBX_Registrar.Controls.Add(this.LBL_Apellidos_Clientes);
            this.GBX_Registrar.Controls.Add(this.TBX_FechaNaci_Cliente);
            this.GBX_Registrar.Controls.Add(this.LBL_Direccion_Cliente);
            this.GBX_Registrar.Controls.Add(this.TBX_RFC);
            this.GBX_Registrar.Controls.Add(this.LBl_Correo);
            this.GBX_Registrar.Controls.Add(this.TBX_Apellidos_Cliente);
            this.GBX_Registrar.Controls.Add(this.LBL_Telefono_Cliente);
            this.GBX_Registrar.Controls.Add(this.TBX_Nombre_Cliente);
            this.GBX_Registrar.Location = new System.Drawing.Point(0, 27);
            this.GBX_Registrar.Name = "GBX_Registrar";
            this.GBX_Registrar.Size = new System.Drawing.Size(317, 292);
            this.GBX_Registrar.TabIndex = 18;
            this.GBX_Registrar.TabStop = false;
            // 
            // GBX_Asignar
            // 
            this.GBX_Asignar.Controls.Add(this.LBL_IDCliente_Cuenta);
            this.GBX_Asignar.Controls.Add(this.BTN_Asignar_Cuenta);
            this.GBX_Asignar.Controls.Add(this.LBL_Contraseña_Cuenta);
            this.GBX_Asignar.Controls.Add(this.LBL_Usuario_Cuenta);
            this.GBX_Asignar.Controls.Add(this.LBL_Asignacion_Cuenta);
            this.GBX_Asignar.Controls.Add(this.TBX_Contraseña_Cuenta);
            this.GBX_Asignar.Controls.Add(this.TBX_Usuario_Cuenta);
            this.GBX_Asignar.Controls.Add(this.TBX_CL_ID);
            this.GBX_Asignar.Location = new System.Drawing.Point(333, 27);
            this.GBX_Asignar.Name = "GBX_Asignar";
            this.GBX_Asignar.Size = new System.Drawing.Size(317, 292);
            this.GBX_Asignar.TabIndex = 19;
            this.GBX_Asignar.TabStop = false;
            // 
            // LBL_IDCliente_Cuenta
            // 
            this.LBL_IDCliente_Cuenta.AutoSize = true;
            this.LBL_IDCliente_Cuenta.Location = new System.Drawing.Point(20, 58);
            this.LBL_IDCliente_Cuenta.Name = "LBL_IDCliente_Cuenta";
            this.LBL_IDCliente_Cuenta.Size = new System.Drawing.Size(69, 13);
            this.LBL_IDCliente_Cuenta.TabIndex = 3;
            this.LBL_IDCliente_Cuenta.Text = "ID del cliente";
            // 
            // BTN_Asignar_Cuenta
            // 
            this.BTN_Asignar_Cuenta.Location = new System.Drawing.Point(121, 259);
            this.BTN_Asignar_Cuenta.Name = "BTN_Asignar_Cuenta";
            this.BTN_Asignar_Cuenta.Size = new System.Drawing.Size(75, 23);
            this.BTN_Asignar_Cuenta.TabIndex = 17;
            this.BTN_Asignar_Cuenta.Text = "Asignar";
            this.BTN_Asignar_Cuenta.UseVisualStyleBackColor = true;
            this.BTN_Asignar_Cuenta.Click += new System.EventHandler(this.Asignar_Click);
            // 
            // LBL_Contraseña_Cuenta
            // 
            this.LBL_Contraseña_Cuenta.AutoSize = true;
            this.LBL_Contraseña_Cuenta.Location = new System.Drawing.Point(20, 110);
            this.LBL_Contraseña_Cuenta.Name = "LBL_Contraseña_Cuenta";
            this.LBL_Contraseña_Cuenta.Size = new System.Drawing.Size(61, 13);
            this.LBL_Contraseña_Cuenta.TabIndex = 1;
            this.LBL_Contraseña_Cuenta.Text = "Contraseña";
            // 
            // LBL_Usuario_Cuenta
            // 
            this.LBL_Usuario_Cuenta.AutoSize = true;
            this.LBL_Usuario_Cuenta.Location = new System.Drawing.Point(20, 84);
            this.LBL_Usuario_Cuenta.Name = "LBL_Usuario_Cuenta";
            this.LBL_Usuario_Cuenta.Size = new System.Drawing.Size(43, 13);
            this.LBL_Usuario_Cuenta.TabIndex = 2;
            this.LBL_Usuario_Cuenta.Text = "Usuario";
            // 
            // LBL_Asignacion_Cuenta
            // 
            this.LBL_Asignacion_Cuenta.AutoSize = true;
            this.LBL_Asignacion_Cuenta.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Asignacion_Cuenta.Location = new System.Drawing.Point(83, 16);
            this.LBL_Asignacion_Cuenta.Name = "LBL_Asignacion_Cuenta";
            this.LBL_Asignacion_Cuenta.Size = new System.Drawing.Size(138, 22);
            this.LBL_Asignacion_Cuenta.TabIndex = 4;
            this.LBL_Asignacion_Cuenta.Text = "Asignar Cuenta";
            // 
            // TBX_Contraseña_Cuenta
            // 
            this.TBX_Contraseña_Cuenta.Location = new System.Drawing.Point(136, 110);
            this.TBX_Contraseña_Cuenta.Name = "TBX_Contraseña_Cuenta";
            this.TBX_Contraseña_Cuenta.Size = new System.Drawing.Size(146, 20);
            this.TBX_Contraseña_Cuenta.TabIndex = 13;
            // 
            // TBX_Usuario_Cuenta
            // 
            this.TBX_Usuario_Cuenta.Location = new System.Drawing.Point(136, 84);
            this.TBX_Usuario_Cuenta.Name = "TBX_Usuario_Cuenta";
            this.TBX_Usuario_Cuenta.Size = new System.Drawing.Size(146, 20);
            this.TBX_Usuario_Cuenta.TabIndex = 12;
            // 
            // TBX_CL_ID
            // 
            this.TBX_CL_ID.Location = new System.Drawing.Point(136, 58);
            this.TBX_CL_ID.Name = "TBX_CL_ID";
            this.TBX_CL_ID.Size = new System.Drawing.Size(146, 20);
            this.TBX_CL_ID.TabIndex = 11;
            // 
            // crearCuentaToolStripMenuItem
            // 
            this.crearCuentaToolStripMenuItem.Name = "crearCuentaToolStripMenuItem";
            this.crearCuentaToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.crearCuentaToolStripMenuItem.Text = "Registrar Cliente";
            this.crearCuentaToolStripMenuItem.Click += new System.EventHandler(this.Menu_Resgistra_Click);
            // 
            // asignarCuentaToolStripMenuItem
            // 
            this.asignarCuentaToolStripMenuItem.Name = "asignarCuentaToolStripMenuItem";
            this.asignarCuentaToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.asignarCuentaToolStripMenuItem.Text = "Crear Cuenta";
            this.asignarCuentaToolStripMenuItem.Click += new System.EventHandler(this.Menu_Asignar_Click);
            // 
            // Form_Gerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 323);
            this.Controls.Add(this.GBX_Asignar);
            this.Controls.Add(this.GBX_Registrar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Gerente";
            this.Text = "Administrador de cuentas";
            this.Load += new System.EventHandler(this.Form_Gerente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GBX_Registrar.ResumeLayout(false);
            this.GBX_Registrar.PerformLayout();
            this.GBX_Asignar.ResumeLayout(false);
            this.GBX_Asignar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label LBL_FechaNaci_Cliente;
        private System.Windows.Forms.Label LBL_RFC;
        private System.Windows.Forms.Label LBL_Nombre_Cliente;
        private System.Windows.Forms.Label LBl_Registro_Cliente;
        private System.Windows.Forms.Label LBL_Apellidos_Clientes;
        private System.Windows.Forms.Label LBL_Direccion_Cliente;
        private System.Windows.Forms.Label LBl_Correo;
        private System.Windows.Forms.Label LBL_Telefono_Cliente;
        private System.Windows.Forms.TextBox TBX_Nombre_Cliente;
        private System.Windows.Forms.TextBox TBX_Apellidos_Cliente;
        private System.Windows.Forms.TextBox TBX_RFC;
        private System.Windows.Forms.TextBox TBX_FechaNaci_Cliente;
        private System.Windows.Forms.TextBox TBX_Direccion_Cliente;
        private System.Windows.Forms.TextBox TBX_Telefon_Cliente;
        private System.Windows.Forms.TextBox TBX_Correo_Cliente;
        private System.Windows.Forms.Button BTN_Agregar_Cliente;
        private System.Windows.Forms.GroupBox GBX_Registrar;
        private System.Windows.Forms.GroupBox GBX_Asignar;
        private System.Windows.Forms.Label LBL_IDCliente_Cuenta;
        private System.Windows.Forms.Button BTN_Asignar_Cuenta;
        private System.Windows.Forms.Label LBL_Contraseña_Cuenta;
        private System.Windows.Forms.Label LBL_Usuario_Cuenta;
        private System.Windows.Forms.Label LBL_Asignacion_Cuenta;
        private System.Windows.Forms.TextBox TBX_Contraseña_Cuenta;
        private System.Windows.Forms.TextBox TBX_Usuario_Cuenta;
        private System.Windows.Forms.TextBox TBX_CL_ID;
        private System.Windows.Forms.ToolStripMenuItem crearCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarCuentaToolStripMenuItem;
    }
}