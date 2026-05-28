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
    public class TVuelo
    {
        public int ingresarVuelo(Vuelo vlo)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO VUELO(NROVUELO,FECHA,HORA,DESTINO) VALUES('{0}','{1}','{2}','{3}')",
                vlo.numvlo, vlo.fecha.ToString("yyyy-MM-dd"), vlo.hora, vlo.destino), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int modificarVuelo(Vuelo vlo)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("UPDATE VUELO SET FECHA='{0}',HORA='{1}',DESTINO='{2}' WHERE NROVUELO='{3}'",
                vlo.fecha.ToString("yyyy-MM-dd"), vlo.hora, vlo.destino, vlo.numvlo), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int modificarFechaVuelo(string nrovuelo, DateTime fecha)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("UPDATE VUELO SET FECHA='{0}' WHERE NROVUELO='{1}'",
                fecha.ToString("yyyy-MM-dd"), nrovuelo), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int eliminarVuelo(string numvlo)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("DELETE FROM VUELO WHERE NROVUELO='{0}'", numvlo), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public Vuelo buscarVuelo(string numvlo)
        {
            Vuelo vlo = new Vuelo();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand("SELECT * FROM VUELO WHERE NROVUELO=@numvlo", conex);
            orden.Parameters.AddWithValue("@numvlo", numvlo);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                vlo.numvlo = lector.GetString(0);
                vlo.fecha = lector.GetDateTime(1);
                vlo.hora = lector.GetString(2);
                vlo.destino = lector.GetString(3);
            }
            conex.Close();
            return vlo;
        }

        public static List<Vuelo> listarVuelo()
        {
            List<Vuelo> lista = new List<Vuelo>();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand("SELECT * FROM VUELO", conex);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Vuelo vlo = new Vuelo();
                vlo.numvlo = lector.GetString(0);
                vlo.fecha = lector.GetDateTime(1);
                vlo.hora = lector.GetString(2);
                vlo.destino = lector.GetString(3);
                lista.Add(vlo);
            }
            conex.Close();
            return lista;
        }
    }
}
