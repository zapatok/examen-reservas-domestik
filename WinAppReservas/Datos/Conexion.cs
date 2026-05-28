using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinAppReservas.Datos
{
    public class Conexion
    {
        public static MySqlConnection abrirConexion()
        {
            MySqlConnection conectar = null;
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1;database=bdreservas;Uid=root;pwd=;");
                conectar.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("CONEXIÓN FALLADA...VERIFIQUE..." + ex.ToString());
            }
            return conectar;
        }
    }
}
