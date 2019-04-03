using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton {
   public static class Connection {
      private static string dataSource = "localhost";
      private static string database = "pubs";
      private static string user = "gest";
      private static string password = "gest@2018";
      private static SqlConnection connection;

      public static SqlConnection Open() {
         if (connection == null) {
            connection = new SqlConnection();
            string cs = "Data Source={0};Initial Catalog={1};User id={2};Password={3};";
            connection.ConnectionString = string.Format(cs, dataSource, database, user, password);
            try {
               //connection.Open();
               return connection;
            }
            catch (Exception error) {
               throw error;
            }
         }
         else {
            return connection;
         }
      }//public static SqlDbConnection Open()

      public static void Close() {
         connection.Close();
      }
   }//public static class SQLServer
}
