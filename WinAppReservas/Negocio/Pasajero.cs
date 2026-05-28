using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppReservas.Negocio
{
    public class Pasajero
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipo { get; set; }
        public int puntaje { get; set; }
        //Constructor s/p
        public Pasajero() { }
        //Constructor con parametros
        public Pasajero(string rut, string nombre, string apellido, string tipo, int puntaje)
        {
            this.rut = rut;
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
            this.puntaje = puntaje;
        }
    }
}
