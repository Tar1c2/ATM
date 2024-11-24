namespace ATM
{
    partial class Form_ATM_AeroSaurio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ATM_AeroSaurio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usuario_lbl = new System.Windows.Forms.Label();
            this.usuario_tbx = new System.Windows.Forms.TextBox();
            this.contrasena_lbl = new System.Windows.Forms.Label();
            this.contrasena_tbx = new System.Windows.Forms.TextBox();
            this.inicio_sesion_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ATM.Properties.Resources.Aerosaur;
            this.pictureBox1.Location = new System.Drawing.Point(94, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usuario_lbl
            // 
            this.usuario_lbl.AutoSize = true;
            this.usuario_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_lbl.Location = new System.Drawing.Point(130, 223);
            this.usuario_lbl.Name = "usuario_lbl";
            this.usuario_lbl.Size = new System.Drawing.Size(87, 26);
            this.usuario_lbl.TabIndex = 1;
            this.usuario_lbl.Text = "Usuario";
            // 
            // usuario_tbx
            // 
            this.usuario_tbx.Location = new System.Drawing.Point(95, 252);
            this.usuario_tbx.Name = "usuario_tbx";
            this.usuario_tbx.Size = new System.Drawing.Size(158, 20);
            this.usuario_tbx.TabIndex = 2;
            // 
            // contrasena_lbl
            // 
            this.contrasena_lbl.AutoSize = true;
            this.contrasena_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contrasena_lbl.Location = new System.Drawing.Point(110, 275);
            this.contrasena_lbl.Name = "contrasena_lbl";
            this.contrasena_lbl.Size = new System.Drawing.Size(124, 26);
            this.contrasena_lbl.TabIndex = 3;
            this.contrasena_lbl.Text = "Contraseña";
            // 
            // contrasena_tbx
            // 
            this.contrasena_tbx.Location = new System.Drawing.Point(95, 304);
            this.contrasena_tbx.Name = "contrasena_tbx";
            this.contrasena_tbx.Size = new System.Drawing.Size(158, 20);
            this.contrasena_tbx.TabIndex = 4;
            this.contrasena_tbx.UseSystemPasswordChar = true;
            // 
            // inicio_sesion_btn
            // 
            this.inicio_sesion_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio_sesion_btn.Location = new System.Drawing.Point(109, 350);
            this.inicio_sesion_btn.Name = "inicio_sesion_btn";
            this.inicio_sesion_btn.Size = new System.Drawing.Size(125, 53);
            this.inicio_sesion_btn.TabIndex = 5;
            this.inicio_sesion_btn.Text = "Inicar Sesion";
            this.inicio_sesion_btn.UseVisualStyleBackColor = true;
            this.inicio_sesion_btn.Click += new System.EventHandler(this.inicio_sesion_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // Form_ATM_AeroSaurio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.inicio_sesion_btn);
            this.Controls.Add(this.contrasena_tbx);
            this.Controls.Add(this.contrasena_lbl);
            this.Controls.Add(this.usuario_tbx);
            this.Controls.Add(this.usuario_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_ATM_AeroSaurio";
            this.Text = "AeroSaurio Bank Services";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usuario_lbl;
        private System.Windows.Forms.TextBox usuario_tbx;
        private System.Windows.Forms.Label contrasena_lbl;
        private System.Windows.Forms.TextBox contrasena_tbx;
        private System.Windows.Forms.Button inicio_sesion_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorToolStripMenuItem;
    }
}

