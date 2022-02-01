using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AutoRepair
{
    class CustomerProvider:DataBase
    {
        DataTable data;
        MySqlDataAdapter baglayici;
        public DataTable get()
        {
            MySqlConnection connection = GetConnection();


            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM customers";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }

        public DataTable update(double PhoneNumber, string Name, string Surname, string Gender,string Address, string Email)
        {

            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE customers SET Name='" + Name + "',Surname='" + Surname +
            "',Gender='" + Gender + "',Address='" + Address + "',Email='" + Email+ "'WHERE  Phone_Number='" + PhoneNumber + "';";
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();

        }

        public bool Contains(double Phone_Number)
        {
            bool result = false;
            using (var connection = GetConnection())
            {
                var command = new MySqlCommand("SELECT *FROM customers WHERE Phone_Number='" + Phone_Number + "'");
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
        public bool Insert(double Phone_Number, string Name, string Surname, string Gender, string Address,string Email)
        {
            bool result = false;

            if (!Contains(Phone_Number))
            {
                using (var connection = GetConnection())
                {
                    var command = new MySqlCommand("INSERT INTO customers(Phone_Number,Name,Surname, Gender,Address,Email) " +
                        "VALUES('" + Phone_Number + "','" + Name + "','" + Surname + "','" + Gender + "','" + Address + "','" + Email+ "')");
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
        public DataTable Remove(double Phone_Number)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            string sql = "DELETE FROM customers WHERE Phone_Number='" + Phone_Number + "'";
            cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();
        }

    }
}
