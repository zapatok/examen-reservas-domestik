using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WinAppReservas.Datos;

namespace WinAppReservas.Login
{
    public class Login
    {
        public Boolean validarUsuario(String usuar, String clave)
        {
            Boolean resp = false;
            MySqlConnection conex = Conexion.abrirConexion();
            MySqlCommand orden = new MySqlCommand("SELECT * FROM CONTROL WHERE USUARIO=@usuar AND CLAVE=@clave", conex);
            orden.Parameters.AddWithValue("@usuar", usuar);
            orden.Parameters.AddWithValue("@clave", clave);
            MySqlDataReader lector = orden.ExecuteReader();
            if (lector.Read())
            {
                resp = true;
            }
            conex.Close();
            return resp;
        }
    }
}
