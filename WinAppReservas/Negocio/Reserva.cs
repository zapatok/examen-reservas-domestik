using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppReservas.Negocio
{
    public class Reserva
    {
        public string codigo { get; set; }
        public string tipo { get; set; }
        public double valor { get; set; }
        public string rut { get; set; }
        public string nrovuelo { get; set; }
        //Constructor s/p
        public Reserva() { }
        //Constructor con parametros
        public Reserva(string codigo, string tipo, double valor, string rut, string nrovuelo)
        {
            this.codigo = codigo;
            this.tipo = tipo;
            this.valor = valor;
            this.rut = rut;
            this.nrovuelo = nrovuelo;
        }
    }
}
