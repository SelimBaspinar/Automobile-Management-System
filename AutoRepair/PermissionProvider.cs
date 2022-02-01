using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRepair
{
    class PermissionProvider:DataBase
    {
        DataTable data;
        MySqlDataAdapter baglayici;
        public DataTable get()
        {
            MySqlConnection connection = GetConnection();


            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM permission";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }

        public DataTable update(int Role_Id, int statistics, int salary, int carpart, int employee,
            int car,int permission,int customer)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "UPDATE permission SET Statistics='" + statistics +
            "',Salary='" + salary + "',Car_Part='" + carpart + "',Employee='" + employee
            + "',Car='" + car + "',Permission='" + permission + "',Customer='" + customer +  "'WHERE  Role_Id='" + Role_Id + "';";
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();

        }

        public bool Contains(int Id)
        {
            bool result = false;
            using (var connection = GetConnection())
            {
                var command = new MySqlCommand("SELECT *FROM permission WHERE Role_Id='" + Id + "'");
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
        public bool Insert(int Role_Id, int statistics, int salary, int carpart, int employee,
            int car, int permission, int customer)
        {
            bool result = false;

            if (!Contains(Role_Id))
            {
               
                        using (var connection = GetConnection())
                        {
                            var command = new MySqlCommand("INSERT INTO permission(Role_Id,Statistics,Salary, Car_Part,Employee," +
                                "Car,Permission,Customer)" + "VALUES('" + Role_Id + "','" + statistics + "','" + salary + "','"
                                + carpart + "','" + employee + "','" + car + "','" + permission + "','" + customer+ "')");
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
        public DataTable Remove(int Role_Id)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            string sql = "DELETE FROM permission WHERE Role_Id='" + Role_Id + "'";
            cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();
        }
    }
}
