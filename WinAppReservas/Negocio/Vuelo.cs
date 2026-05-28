using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppReservas.Negocio
{
    public class Vuelo
    {
        public string numvlo { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public string destino { get; set; }
        //Constructor s/p
        public Vuelo() { }
        //Constructor con parametros
        public Vuelo(string numvlo, DateTime fecha, string hora, string destino)
        {
            this.numvlo = numvlo;
            this.fecha = fecha;
            this.hora = hora;
            this.destino = destino;
        }
    }
}
