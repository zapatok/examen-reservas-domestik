using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppReservas.Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gestionPasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPasajero frmPas = new FrmPasajero();
            frmPas.Show();
        }

        private void gestionVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVuelo frmVlo = new FrmVuelo();
            frmVlo.Show();
        }

        private void gestionReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReserva frmRes = new FrmReserva();
            frmRes.Show();
        }

        private void salirDeAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea salir?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
                Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
