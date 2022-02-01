using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AutoRepair
{
    class EmployeeProvider : DataBase
    {
        DataTable data;
        MySqlDataAdapter baglayici;
        public DataTable get()
        {
            MySqlConnection connection = GetConnection();


            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT * FROM employee";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }
        public DataTable getroleid(string username)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT Role_Id FROM employee where Username='" + username + "'";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }
        public DataTable getusername(string username)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT* FROM employee where Username='" + username + "'";
            data = new DataTable();
            baglayici = new MySqlDataAdapter();
            baglayici.SelectCommand = cmd;
            baglayici.Fill(data);
            cmd.ExecuteNonQuery();
            connection.Close();
            return data;
        }
        public DataTable update(string Username, int Role_Id, string Email, string Name, string Surname, string Gender,
            string Address, double Phone_Number, double Salary, string Working_Hours)
        {

            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandText = "UPDATE employee SET Role_Id='" + Role_Id + "',Email='" + Email +
            "',Name='" + Name + "',Surname='" + Surname + "',Gender='" + Gender
            + "',Address='" + Address + "',Phone_Number='" + Phone_Number + "',Salary='" + Salary +
            "',Working_Hours='" + Working_Hours + "'WHERE  Username='" + Username + "';";
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();

        }

        public bool Contains(string Username, double phonenumber, string email)
        {
            bool result = false;
            using (var connection = GetConnection())
            {
                var command = new MySqlCommand("SELECT *FROM employee WHERE Username='" + Username + "'");
                command.Connection = connection;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                        result = true;
                    else
                    {
                        result = false;
                        connection.Close();
                        command = new MySqlCommand("SELECT *FROM employee WHERE Phone_Number='" + phonenumber + "'");
                        command.Connection = connection;
                        connection.Open();
                        using (var reader1 = command.ExecuteReader())
                        {
                            if (reader1.Read())
                                result = true;
                            else
                            {
                                result = false;
                                connection.Close();
                                command = new MySqlCommand("SELECT *FROM employee WHERE Email='" + email + "'");
                                command.Connection = connection;
                                connection.Open();
                                using (var reader2 = command.ExecuteReader())
                                {
                                    if (reader2.Read())
                                        result = true;
                                    else
                                    {
                                        result = false;
                                    }
                                }
                            }
                        }
                    }
                }
                connection.Close();

            }
            return result;
        }
        public bool Insert(string Username, int Role_Id, string Email, string Name, string Surname, string Gender,
            string Address, double Phone_Number, double Salary, string Working_Hours)
        {
            bool result = false;

            if (!Contains(Username, Phone_Number, Email))
            {

                using (var connection = GetConnection())
                {
                    var command = new MySqlCommand("INSERT INTO employee(Username,Role_Id,Email, Name,Surname," +
                        "Gender,Address,Phone_Number,Salary,Working_Hours)" + "VALUES('" + Username + "','" + Role_Id + "','" + Email + "','"
                        + Name + "','" + Surname + "','" + Gender + "','" + Address + "','" + Phone_Number +
                        "','" + Salary + "','" + Working_Hours + "')");
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
        public DataTable Remove(string Username)
        {
            MySqlConnection connection = GetConnection();
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            string sql = "DELETE FROM login WHERE Username='" + Username + "'";
            cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            sql = "DELETE FROM employee WHERE Username='" + Username + "'";
            cmd = new MySqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return get();
        }
    }
}
