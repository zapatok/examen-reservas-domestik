using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WinAppReservas.Datos;
using WinAppReservas.Negocio;

namespace WinAppReservas.Control
{
    public class TReserva
    {
        //Valores base, embarque y puntaje segun tipo reserva
        public static double obtenerValorBase(string tipo)
        {
            switch (tipo)
            {
                case "Economica": return 30000;
                case "Turista": return 40000;
                case "Ejecutivo": return 60000;
                default: return 0;
            }
        }

        public static double obtenerGastoEmbarque(string tipo)
        {
            switch (tipo)
            {
                case "Economica": return 5500;
                case "Turista": return 6000;
                case "Ejecutivo": return 10000;
                default: return 0;
            }
        }

        public static int obtenerPuntaje(string tipo)
        {
            switch (tipo)
            {
                case "Economica": return 500;
                case "Turista": return 700;
                case "Ejecutivo": return 1000;
                default: return 0;
            }
        }

        public static double calcularCostoPasaje(string tipo)
        {
            return obtenerValorBase(tipo) + obtenerGastoEmbarque(tipo);
        }

        public static string obtenerCondicion(string tipo)
        {
            switch (tipo)
            {
                case "Economica": return "No sujeta a cambio";
                case "Turista": return "Para cambio debe pagar 10% del valor base";
                case "Ejecutivo": return "Puede efectuar cambio sin costo";
                default: return "";
            }
        }

        public int ingresarReserva(Reserva res)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO RESERVA(CODIGO,TIPO,VALOR,RUT,NROVUELO) VALUES('{0}','{1}',{2},'{3}','{4}')",
                res.codigo, res.tipo, res.valor, res.rut, res.nrovuelo), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int actualizarPuntajePasajero(string rut, int puntajeAdicional)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("UPDATE PASAJERO SET PUNTAJE=PUNTAJE+{0} WHERE RUT='{1}'",
                puntajeAdicional, rut), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int eliminarReserva(string codigo)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("DELETE FROM RESERVA WHERE CODIGO='{0}'", codigo), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public Reserva buscarReserva(string codigo)
        {
            Reserva res = new Reserva();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand("SELECT * FROM RESERVA WHERE CODIGO=@codigo", conex);
            orden.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                res.codigo = lector.GetString(0);
                res.tipo = lector.GetString(1);
                res.valor = lector.GetDouble(2);
                res.rut = lector.GetString(3);
                res.nrovuelo = lector.GetString(4);
            }
            conex.Close();
            return res;
        }

        public static List<Reserva> listarReserva()
        {
            List<Reserva> lista = new List<Reserva>();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand("SELECT * FROM RESERVA", conex);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Reserva res = new Reserva();
                res.codigo = lector.GetString(0);
                res.tipo = lector.GetString(1);
                res.valor = lector.GetDouble(2);
                res.rut = lector.GetString(3);
                res.nrovuelo = lector.GetString(4);
                lista.Add(res);
            }
            conex.Close();
            return lista;
        }
    }
}
