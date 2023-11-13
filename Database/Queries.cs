using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Database
{
    public class Queries {
        public static DataTable results(String query) {
             try {
                 using(MySqlCommand cmd = new MySqlCommand(query, Connection.Open())) {
                     MySqlDataReader dr = cmd.ExecuteReader();
                     DataTable dt = new DataTable();
                     dt.Load(dr);
                     return dt;
                 }

             } catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
                #pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
                return null;
                #pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo
            }
        }
        
    }
}
