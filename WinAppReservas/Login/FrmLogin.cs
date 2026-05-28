using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppReservas.Vista;

namespace WinAppReservas.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Login login = new Login();
                Boolean resultado = login.validarUsuario(txtUsuario.Text, txtClave.Text);
                if (resultado)
                {
                    this.Hide();
                    Form1 frmpp = new Form1();
                    frmpp.Show();
                }
                else
                {
                    MessageBox.Show("Verifique credenciales...", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
