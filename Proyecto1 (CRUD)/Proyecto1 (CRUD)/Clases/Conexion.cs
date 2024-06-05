using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1__CRUD_.Clases
{
    internal class Conexion
    {
        MySqlConnection conex = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "escuelas";
        static string ususario = "root";
        static string password = "root";
        static string puerto = "3306";
        



        string cadenaConexion = "server=" + servidor + ";"+"port=" + puerto +";" + "user id=" + ususario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        //abrir conexion
        public MySqlConnection establecerConexcion()
        {
            try
            {
                //abrir conexcion
                conex.ConnectionString = cadenaConexion;
                conex.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se concecto a la base de datos, error: "+ex.Message);
                
            }
            return conex;
        }
        //cerrar la conexcion
        public void cerrarConexion()
        {
            conex.Close();
        }

    }
}
