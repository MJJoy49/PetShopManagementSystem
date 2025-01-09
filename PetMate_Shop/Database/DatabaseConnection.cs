using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetMate_Shop.Database
{
    public static class DatabaseConnection
    {
        
        //"data source=YourServerName; database=DB_Name; integrated security=SSPI"

        private static readonly string connectionString = "data source=DESKTOP-M4S4J3H\\SQLEXPRESS; database=PetMate; integrated security=SSPI";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
