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
    public class TPasajero
    {
        public int ingresarPasajero(Pasajero pas)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("INSERT INTO PASAJERO(RUT,NOMBRE,APELLIDO,TIPO,PUNTAJE) VALUES('{0}','{1}','{2}','{3}',{4})",
                pas.rut, pas.nombre, pas.apellido, pas.tipo, pas.puntaje), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int modificarPasajero(Pasajero pas)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("UPDATE PASAJERO SET NOMBRE='{0}',APELLIDO='{1}',TIPO='{2}',PUNTAJE={3} WHERE RUT='{4}'",
                pas.nombre, pas.apellido, pas.tipo, pas.puntaje, pas.rut), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public int eliminarPasajero(string rut)
        {
            int resp = 0;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand(string.Format("DELETE FROM PASAJERO WHERE RUT='{0}'", rut), conex);
            resp = orden.ExecuteNonQuery();
            conex.Close();
            return resp;
        }

        public Pasajero buscarPasajero(string rut)
        {
            Pasajero pas = new Pasajero();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand("SELECT * FROM PASAJERO WHERE RUT=@rut", conex);
            orden.Parameters.AddWithValue("@rut", rut);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                pas.rut = lector.GetString(0);
                pas.nombre = lector.GetString(1);
                pas.apellido = lector.GetString(2);
                pas.tipo = lector.GetString(3);
                pas.puntaje = lector.GetInt32(4);
            }
            conex.Close();
            return pas;
        }

        public static List<Pasajero> listarPasajero()
        {
            List<Pasajero> lista = new List<Pasajero>();
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand("SELECT * FROM PASAJERO", conex);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Pasajero pas = new Pasajero();
                pas.rut = lector.GetString(0);
                pas.nombre = lector.GetString(1);
                pas.apellido = lector.GetString(2);
                pas.tipo = lector.GetString(3);
                pas.puntaje = lector.GetInt32(4);
                lista.Add(pas);
            }
            conex.Close();
            return lista;
        }
    }
}
