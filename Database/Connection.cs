using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Database
{
    public class Connection {
        private static MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=pas;UID=root;PASSWORD=toor");
        public static MySqlConnection Open() {
            if (connection.State == System.Data.ConnectionState.Closed) {
                connection.Open();
            }
            return connection;
        }

        public static MySqlConnection Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
