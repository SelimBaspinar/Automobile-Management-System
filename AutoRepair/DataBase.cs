using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepair
{
    public class DataBase
    {
        public static MySqlConnection GetConnection()
        {
            string connection;
                connection = @"Data Source=localhost;port=3306;Initial Catalog=autorepair;User Id=root;password=''";
            return new MySqlConnection(connection);
        }
    }
}
