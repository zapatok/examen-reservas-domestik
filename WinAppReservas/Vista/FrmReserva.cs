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
    public partial class FrmReserva : Form
    {
        public FrmReserva()
        {
            InitializeComponent();
        }

        //Al cambiar tipo, calcular costo automaticamente
        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedItem != null)
            {
                double costo = TReserva.calcularCostoPasaje(cboTipo.Text);
                txtCosto.Text = costo.ToString();
            }
        }

        //Ingresar reserva
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva res = new Reserva();
                TReserva tres = new TReserva();
                res.codigo = txtCodigo.Text;
                res.tipo = cboTipo.Text;
                res.valor = TReserva.calcularCostoPasaje(cboTipo.Text);
                res.rut = txtRut.Text;
                res.nrovuelo = txtNumVlo.Text;
                int resp = tres.ingresarReserva(res);
                if (resp > 0)
                {
                    MessageBox.Show("Reserva ingresada correctamente", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Asignar puntaje si pasajero es Frecuente
                    TPasajero tpas = new TPasajero();
                    Pasajero pas = tpas.buscarPasajero(res.rut);
                    if (pas != null && pas.tipo == "Frecuente")
                    {
                        int puntaje = TReserva.obtenerPuntaje(res.tipo);
                        tres.actualizarPuntajePasajero(res.rut, puntaje);
                        MessageBox.Show("Puntaje asignado: " + puntaje + " puntos", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Error al ingresar reserva", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Consultar reserva con condicion, costo y puntaje
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                TReserva tres = new TReserva();
                Reserva res = tres.buscarReserva(txtCodigoBus.Text);
                if (res != null && res.codigo != null)
                {
                    lblCodigo.Text = res.codigo;
                    lblTipo.Text = res.tipo;
                    lblValor.Text = res.valor.ToString();
                    lblRut.Text = res.rut;
                    lblNumVlo.Text = res.nrovuelo;
                    lblCondicion.Text = TReserva.obtenerCondicion(res.tipo);
                    lblCosto.Text = "$" + res.valor.ToString("N0");

                    TPasajero tpas = new TPasajero();
                    Pasajero pas = tpas.buscarPasajero(res.rut);
                    if (pas != null)
                    {
                        lblTipoPasajero.Text = pas.tipo;
                        lblPuntaje.Text = pas.puntaje.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Reserva no encontrada", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Buscar reserva para modificar fecha del vuelo
        private void btnBuscarMod_Click(object sender, EventArgs e)
        {
            try
            {
                TReserva tres = new TReserva();
                Reserva res = tres.buscarReserva(txtCodigoMod.Text);
                if (res != null && res.codigo != null)
                {
                    TVuelo tvlo = new TVuelo();
                    Vuelo vlo = tvlo.buscarVuelo(res.nrovuelo);
                    if (vlo != null)
                    {
                        lblNumVloMod.Text = vlo.numvlo;
                        lblDestinoMod.Text = vlo.destino;
                        lblHoraMod.Text = vlo.hora;
                        dtpFechaMod.Value = vlo.fecha;
                    }
                }
                else
                {
                    MessageBox.Show("Reserva no encontrada", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Modificar fecha del vuelo asociado
        private void btnModFecha_Click(object sender, EventArgs e)
        {
            try
            {
                TReserva tres = new TReserva();
                Reserva res = tres.buscarReserva(txtCodigoMod.Text);
                if (res != null && res.tipo == "Economica")
                {
                    MessageBox.Show("No sujeta a cambio", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TVuelo tvlo = new TVuelo();
                int resp = tvlo.modificarFechaVuelo(lblNumVloMod.Text, dtpFechaMod.Value);
                if (resp > 0)
                {
                    string msg = "Fecha modificada correctamente";
                    if (res != null && res.tipo == "Turista")
                        msg += "\nPara cambio debe pagar 10% del valor base ($" + (TReserva.obtenerValorBase("Turista") * 0.10).ToString("N0") + ")";
                    MessageBox.Show(msg, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error al modificar fecha", "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "AVISO DE SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Listar reservas
        private void btnListar_Click(object sender, EventArgs e)
        {
            dataReservas.DataSource = TReserva.listarReserva();
        }
    }
}
