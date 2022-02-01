using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AutoRepair
{
    class CarProvider : DataBase
    {
        DataTable data;
        MySqlDataAdapter baglayici;
        public DataTable get()
        {
            MySqlConnection connection = GetConnection();


            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM car";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }

        public DataTable update(int Id, String brandv, string modelv, string repairstat, int repairfee, string repairtime, string damagereport, string type)
        {

            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE car SET Brand='" + brandv + "',Model='" + modelv +
            "',Repair_Status='" + repairstat + "',Repair_fee='" + repairfee + "',Repair_Time='" + repairtime
            + "',Damage_Report='" + damagereport + "',Type='" + type + "'WHERE  Car_Id='" + Id + "';";
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();

        }

        public bool Contains(string Id)
        {
            bool result = false;
            using (var connection = GetConnection())
            {
                var command = new MySqlCommand("SELECT *FROM car WHERE Car_Id='" + Id + "'");
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
        public bool Insert(string Id, string Brand, string Model, string Repair_Status, string Repair_fee, string Repair_Time, string Damage_Report, string type)
        {
            bool result = false;

            if (!Contains(Id))
            {
                using (var connection = GetConnection())
                {
                    var command = new MySqlCommand("INSERT INTO car(Car_Id,Brand,Model, Repair_Status,Repair_fee," +
                        "Repair_Time,Damage_Report,Type) VALUES('" + Id + "','" + Brand + "','" + Model + "','"
                        + Repair_Status + "','" + Repair_fee + "','" + Repair_Time + "','" + Damage_Report
                        + "','" + type + "')");
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
            string sql = "DELETE FROM car WHERE Car_Id='" + Id + "'";
            cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();  
        }
    }


}


