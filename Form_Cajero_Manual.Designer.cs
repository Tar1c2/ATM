namespace ATM
{
    partial class Form_Cajero_Manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cajero_Manual));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trasnferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerodecuenta_lbl = new System.Windows.Forms.Label();
            this.ncuenta_tbx = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaccionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargoToolStripMenuItem,
            this.abonoToolStripMenuItem,
            this.trasnferenciaToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // cargoToolStripMenuItem
            // 
            this.cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            this.cargoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargoToolStripMenuItem.Text = "Cargo";
            // 
            // abonoToolStripMenuItem
            // 
            this.abonoToolStripMenuItem.Name = "abonoToolStripMenuItem";
            this.abonoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abonoToolStripMenuItem.Text = "Abono";
            // 
            // trasnferenciaToolStripMenuItem
            // 
            this.trasnferenciaToolStripMenuItem.Name = "trasnferenciaToolStripMenuItem";
            this.trasnferenciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trasnferenciaToolStripMenuItem.Text = "Trasnferencia";
            // 
            // numerodecuenta_lbl
            // 
            this.numerodecuenta_lbl.AutoSize = true;
            this.numerodecuenta_lbl.Location = new System.Drawing.Point(14, 53);
            this.numerodecuenta_lbl.Name = "numerodecuenta_lbl";
            this.numerodecuenta_lbl.Size = new System.Drawing.Size(95, 13);
            this.numerodecuenta_lbl.TabIndex = 1;
            this.numerodecuenta_lbl.Text = "Numero de cuenta";
            // 
            // ncuenta_tbx
            // 
            this.ncuenta_tbx.Location = new System.Drawing.Point(12, 69);
            this.ncuenta_tbx.Name = "ncuenta_tbx";
            this.ncuenta_tbx.Size = new System.Drawing.Size(155, 20);
            this.ncuenta_tbx.TabIndex = 2;
            // 
            // Form_Cajero_Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.ncuenta_tbx);
            this.Controls.Add(this.numerodecuenta_lbl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_Cajero_Manual";
            this.Text = "Cajero";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trasnferenciaToolStripMenuItem;
        private System.Windows.Forms.Label numerodecuenta_lbl;
        private System.Windows.Forms.TextBox ncuenta_tbx;
    }
}