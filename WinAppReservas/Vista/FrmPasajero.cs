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
    public partial class FrmPasajero : Form
    {
        public FrmPasajero()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                TPasajero tpas = new TPasajero();
                //Verificar que no exista
                Pasajero existente = tpas.buscarPasajero(txtRut.Text);
                if (existente != null && existente.rut != null)
                {
                    MessageBox.Show("Pasajero ya existe en el sistema", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Pasajero pas = new Pasajero();
                pas.rut = txtRut.Text;
                pas.nombre = txtNombre.Text;
                pas.apellido = txtApellido.Text;
                pas.tipo = cboTipo.Text;
                pas.puntaje = Convert.ToInt32(txtPuntaje.Text);
                int resp = tpas.ingresarPasajero(pas);
                if (resp > 0)
                    MessageBox.Show("Pasajero ingresado correctamente", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error al ingresar pasajero", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TPasajero tpas = new TPasajero();
            string rut = txtRutBus.Text;
            Pasajero pas = tpas.buscarPasajero(rut);
            if (pas != null)
            {
                txtRutEd.Text = pas.rut;
                txtNombreEd.Text = pas.nombre;
                txtApellidoEd.Text = pas.apellido;
                cboTipoEd.Text = pas.tipo;
                txtPuntajeEd.Text = pas.puntaje.ToString();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Pasajero pas = new Pasajero();
                TPasajero tpas = new TPasajero();
                pas.rut = txtRutEd.Text;
                pas.nombre = txtNombreEd.Text;
                pas.apellido = txtApellidoEd.Text;
                pas.tipo = cboTipoEd.Text;
                pas.puntaje = Convert.ToInt32(txtPuntajeEd.Text);
                int resp = tpas.modificarPasajero(pas);
                if (resp > 0)
                    MessageBox.Show("Pasajero modificado correctamente", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Modificación de pasajero fallada", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                TPasajero tpas = new TPasajero();
                string rut = txtRutBus.Text;
                int resp = tpas.eliminarPasajero(rut);
                if (resp > 0)
                    MessageBox.Show("Pasajero eliminado correctamente", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Eliminación de pasajero fallada", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataPasajeros.DataSource = TPasajero.listarPasajero();
        }
    }
}
