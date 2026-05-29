using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinAppReservas.Negocio;
using WinAppReservas.Control;

namespace WinAppReservas.Vista
{
    public partial class FrmVuelo : Form
    {
        public FrmVuelo()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                TVuelo tvlo = new TVuelo();
                //Verificar que no exista
                Vuelo existente = tvlo.buscarVuelo(txtNumVlo.Text);
                if (existente != null && existente.numvlo != null)
                {
                    MessageBox.Show("Vuelo ya existe en el sistema", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Vuelo vlo = new Vuelo();
                vlo.numvlo = txtNumVlo.Text;
                vlo.fecha = dtpFecha.Value;
                vlo.hora = txtHora.Text;
                vlo.destino = txtDestino.Text;
                int resp = tvlo.ingresarVuelo(vlo);
                if (resp > 0)
                    MessageBox.Show("Vuelo ingresado correctamente", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error al ingresar vuelo", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TVuelo tvlo = new TVuelo();
            string numvlo = txtNumVloBus.Text;
            Vuelo vlo = tvlo.buscarVuelo(numvlo);
            if (vlo != null)
            {
                txtNumVloEd.Text = vlo.numvlo;
                dtpFechaEd.Value = vlo.fecha;
                txtHoraEd.Text = vlo.hora;
                txtDestinoEd.Text = vlo.destino;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Vuelo vlo = new Vuelo();
                TVuelo tvlo = new TVuelo();
                vlo.numvlo = txtNumVloEd.Text;
                vlo.fecha = dtpFechaEd.Value;
                vlo.hora = txtHoraEd.Text;
                vlo.destino = txtDestinoEd.Text;
                int resp = tvlo.modificarVuelo(vlo);
                if (resp > 0)
                    MessageBox.Show("Vuelo modificado correctamente", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Modificación de vuelo fallada", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TVuelo tvlo = new TVuelo();
                string numvlo = txtNumVloBus.Text;
                int resp = tvlo.eliminarVuelo(numvlo);
                if (resp > 0)
                    MessageBox.Show("Vuelo eliminado correctamente", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Eliminación de vuelo fallada", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataVuelos.DataSource = TVuelo.listarVuelo();
        }
    }
}
