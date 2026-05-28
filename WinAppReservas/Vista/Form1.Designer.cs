namespace WinAppReservas.Vista
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codigo generado por el Disenador de Windows Forms

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPasajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDeAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasajerosToolStripMenuItem,
            this.vuelosToolStripMenuItem,
            this.reservasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // pasajerosToolStripMenuItem
            //
            this.pasajerosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionPasajerosToolStripMenuItem});
            this.pasajerosToolStripMenuItem.Name = "pasajerosToolStripMenuItem";
            this.pasajerosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.pasajerosToolStripMenuItem.Text = "Pasajeros";
            //
            // gestionPasajerosToolStripMenuItem
            //
            this.gestionPasajerosToolStripMenuItem.Name = "gestionPasajerosToolStripMenuItem";
            this.gestionPasajerosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionPasajerosToolStripMenuItem.Text = "Gestión Pasajeros";
            this.gestionPasajerosToolStripMenuItem.Click += new System.EventHandler(this.gestionPasajerosToolStripMenuItem_Click);
            //
            // vuelosToolStripMenuItem
            //
            this.vuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionVuelosToolStripMenuItem});
            this.vuelosToolStripMenuItem.Name = "vuelosToolStripMenuItem";
            this.vuelosToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.vuelosToolStripMenuItem.Text = "Vuelos";
            //
            // gestionVuelosToolStripMenuItem
            //
            this.gestionVuelosToolStripMenuItem.Name = "gestionVuelosToolStripMenuItem";
            this.gestionVuelosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionVuelosToolStripMenuItem.Text = "Gestión Vuelos";
            this.gestionVuelosToolStripMenuItem.Click += new System.EventHandler(this.gestionVuelosToolStripMenuItem_Click);
            //
            // reservasToolStripMenuItem
            //
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionReservasToolStripMenuItem});
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.reservasToolStripMenuItem.Text = "Reservas";
            //
            // gestionReservasToolStripMenuItem
            //
            this.gestionReservasToolStripMenuItem.Name = "gestionReservasToolStripMenuItem";
            this.gestionReservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionReservasToolStripMenuItem.Text = "Gestión Reservas";
            this.gestionReservasToolStripMenuItem.Click += new System.EventHandler(this.gestionReservasToolStripMenuItem_Click);
            //
            // salirToolStripMenuItem
            //
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDeAplicacionToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            //
            // salirDeAplicacionToolStripMenuItem
            //
            this.salirDeAplicacionToolStripMenuItem.Name = "salirDeAplicacionToolStripMenuItem";
            this.salirDeAplicacionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDeAplicacionToolStripMenuItem.Text = "Salir de Aplicación";
            this.salirDeAplicacionToolStripMenuItem.Click += new System.EventHandler(this.salirDeAplicacionToolStripMenuItem_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Reservas - Aerolínea Domestik";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPasajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDeAplicacionToolStripMenuItem;
    }
}
