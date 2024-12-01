namespace ATM
{
    partial class Form_Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Clientes));
            this.ncuenta_tbx = new System.Windows.Forms.TextBox();
            this.numerodecuenta_lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasnferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datos_cuenta_receptor = new System.Windows.Forms.DataGridView();
            this.cancelar_btn = new System.Windows.Forms.Button();
            this.Fienalizar_btn = new System.Windows.Forms.Button();
            this.datos_transaccion = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_cuenta_receptor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_transaccion)).BeginInit();
            this.SuspendLayout();
            // 
            // ncuenta_tbx
            // 
            this.ncuenta_tbx.Location = new System.Drawing.Point(306, 47);
            this.ncuenta_tbx.Name = "ncuenta_tbx";
            this.ncuenta_tbx.Size = new System.Drawing.Size(155, 20);
            this.ncuenta_tbx.TabIndex = 5;
            this.ncuenta_tbx.Visible = false;
            // 
            // numerodecuenta_lbl
            // 
            this.numerodecuenta_lbl.AutoSize = true;
            this.numerodecuenta_lbl.Location = new System.Drawing.Point(303, 31);
            this.numerodecuenta_lbl.Name = "numerodecuenta_lbl";
            this.numerodecuenta_lbl.Size = new System.Drawing.Size(95, 13);
            this.numerodecuenta_lbl.TabIndex = 4;
            this.numerodecuenta_lbl.Text = "Numero de cuenta";
            this.numerodecuenta_lbl.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesToolStripMenuItem,
            this.cuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trasnferenciaToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // trasnferenciaToolStripMenuItem
            // 
            this.trasnferenciaToolStripMenuItem.Name = "trasnferenciaToolStripMenuItem";
            this.trasnferenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trasnferenciaToolStripMenuItem.Text = "Trasnferencia";
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaciónToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // informaciónToolStripMenuItem
            // 
            this.informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            this.informaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informaciónToolStripMenuItem.Text = "Información";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // datos_cuenta_receptor
            // 
            this.datos_cuenta_receptor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_cuenta_receptor.Location = new System.Drawing.Point(302, 77);
            this.datos_cuenta_receptor.Name = "datos_cuenta_receptor";
            this.datos_cuenta_receptor.Size = new System.Drawing.Size(311, 79);
            this.datos_cuenta_receptor.TabIndex = 6;
            this.datos_cuenta_receptor.Visible = false;
            // 
            // cancelar_btn
            // 
            this.cancelar_btn.Location = new System.Drawing.Point(303, 247);
            this.cancelar_btn.Name = "cancelar_btn";
            this.cancelar_btn.Size = new System.Drawing.Size(75, 41);
            this.cancelar_btn.TabIndex = 7;
            this.cancelar_btn.Text = "Cancelar";
            this.cancelar_btn.UseVisualStyleBackColor = true;
            // 
            // Fienalizar_btn
            // 
            this.Fienalizar_btn.Location = new System.Drawing.Point(539, 247);
            this.Fienalizar_btn.Name = "Fienalizar_btn";
            this.Fienalizar_btn.Size = new System.Drawing.Size(75, 41);
            this.Fienalizar_btn.TabIndex = 8;
            this.Fienalizar_btn.Text = "Cancelar";
            this.Fienalizar_btn.UseVisualStyleBackColor = true;
            // 
            // datos_transaccion
            // 
            this.datos_transaccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos_transaccion.Location = new System.Drawing.Point(302, 162);
            this.datos_transaccion.Name = "datos_transaccion";
            this.datos_transaccion.Size = new System.Drawing.Size(311, 79);
            this.datos_transaccion.TabIndex = 9;
            this.datos_transaccion.Visible = false;
            // 
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.datos_transaccion);
            this.Controls.Add(this.Fienalizar_btn);
            this.Controls.Add(this.cancelar_btn);
            this.Controls.Add(this.datos_cuenta_receptor);
            this.Controls.Add(this.ncuenta_tbx);
            this.Controls.Add(this.numerodecuenta_lbl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datos_cuenta_receptor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datos_transaccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ncuenta_tbx;
        private System.Windows.Forms.Label numerodecuenta_lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasnferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.DataGridView datos_cuenta_receptor;
        private System.Windows.Forms.Button cancelar_btn;
        private System.Windows.Forms.Button Fienalizar_btn;
        private System.Windows.Forms.DataGridView datos_transaccion;
    }
}