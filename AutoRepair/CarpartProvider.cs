using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AutoRepair
{
    class CarpartProvider : DataBase
    {
        DataTable data;
        MySqlDataAdapter baglayici;
        public DataTable get()
        {
            MySqlConnection connection = GetConnection();


            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM car_part";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }

        public DataTable update(int Id, String Order_Date, string Items, int Count, int Price)
        {

            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE car_part SET Order_Date='" + Order_Date + "',Items='" + Items +
            "',Count='" + Count + "',Price='" + Price  + "'WHERE  Item_Id='" + Id + "';";
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();

        }

        public bool Contains(string Id)
        {
            bool result = false;
            using (var connection = GetConnection())
            {
                var command = new MySqlCommand("SELECT *FROM car_part WHERE Item_Id='" + Id + "'");
                command.Connection = connection;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        result = true;
                    else
                        result = false;

                }
                connection.Close();

            }
            return result;
        }
        public bool Insert(string Id, string Order_Date, string Items, int Count, int Price)
        {
            bool result = false;

            if (!Contains(Id))
            {
                using (var connection = GetConnection())
                {
                    var command = new MySqlCommand("INSERT INTO car_part(Item_Id,Order_Date,Items, Count,Price) " +
                        "VALUES('" + Id + "','" + Order_Date + "','" + Items + "','" + Count + "','" + Price + "')");
                    command.Connection = connection;
                    connection.Open();
                    if (command.ExecuteNonQuery() != -1)
                    {
                        result = true;
                    }
                    connection.Close();
                }
            }
            return result;
        }
        public DataTable Remove(int Id)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            string sql = "DELETE FROM car_part WHERE Item_Id='" + Id + "'";
            cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();
        }
    }

}
