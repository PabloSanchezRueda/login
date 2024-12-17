using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Login.Data
{
    internal class Connection
    {

        public static string server = "127.0.0.1";
        public static string dataBase = "login";
        public static string user = "root";
        public static string psw = "23344Ps30@@";

        public static MySqlConnection connMaster = new MySqlConnection();

        public static void openConnection()
        {
            string connectionString = $"server={server};database={dataBase};user={user};password={psw};";
            
            try
            {
                connMaster = new MySqlConnection(connectionString);

                connMaster.Open();
            } catch (Exception e)
            {

            }


            if (connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexion establecida");
            }
            else {
                MessageBox.Show("Conexion no establecida");
            }

        }


        public static void closeConnection()
        {

        }


    }
}
