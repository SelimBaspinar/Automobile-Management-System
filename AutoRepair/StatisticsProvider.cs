using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepair
{
    class StatisticsProvider : DataBase
    {
        DataTable data;
        MySqlDataAdapter baglayici;
        public DataTable get()
        {
            MySqlConnection connection = GetConnection();


            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM statistics";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }
        public DataTable getcarcount(string brand)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Car_Count FROM statistics where Brand='" + brand + "'";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }
        public DataTable getrepaircount(string brand)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Repair_Count FROM statistics where Brand='" + brand + "'";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }
        public DataTable update(string brand, int repaircount, int carcount)
        {

            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE statistics SET Repair_Count='" + repaircount + "',Car_Count='" + carcount +
            "'WHERE  Brand='" + brand + "';";
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();

        }

        public bool Contains(string brand)
        {
            bool result = false;
            using (var connection = GetConnection())
            {
                var command = new MySqlCommand("SELECT *FROM statistics WHERE Brand='" + brand + "'");
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
        public bool Insert(string brand, int carcount, int repaircount)
        {
            bool result = false;

            if (!Contains(brand))
            {
                using (var connection = GetConnection())
                {
                    var command = new MySqlCommand("INSERT INTO statistics(Brand,Car_Count,Repair_Count) " +
                        "VALUES('" + brand + "','" + carcount + "','" + repaircount + "')");
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
        public DataTable Remove(int Brand)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            string sql = "DELETE FROM statistics WHERE Brand='" + Brand + "'";
            cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();
        }
    }
}
