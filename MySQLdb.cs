using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BUS_ORGANIZATION
{
    internal class MySQLdb
    {
        MySqlConnection connection;
        static string host = "localhost";
        static string port = "3307";
        static string database = "bus_org_auto";
        static string user = "root";
        static string password = "Development";
        public bool Open()
        {
            try
            {
                connection = new MySqlConnection(
                    "server=" + host +
                    ";port=" + port +
                    ";username=" + user +
                    ";password=" + password +
                    ";database=" + database);
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка соединения к БД\nПричина: " + e.Message, "Information");
            }
            return false;
        }
        public bool Close()
        {
            try
            {
                connection.Close();
                connection.Dispose();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка отсоединения от БД\nПричина: " + e.Message, "Information");
            }
            return false;
        }
        public bool CheckLogin(String login, String passwd)
        {
            try
            {
                Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM users WHERE login = @login AND password = @passwd"
                    );
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = passwd;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Пользователь залогинен");
                    return true;
                }
                else if (table.Rows.Count == 0)
                    MessageBox.Show("Введено неверное имя пользователя или пароль");
                else
                    MessageBox.Show("Таких пользователей несколько\n" +
                        "Так быть не должно, обратитесь к администратору");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка входа\nПричина: " + e.Message);
            }
            Close();
            return false;
        }
        public bool AddUser(String login, String passwd, String passwdconf)
        {
            try
            {
                if (passwd != passwdconf)
                {
                    throw new Exception("Passwords do not match");
                }
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO user (login, password) VALUES (@login, @passwd)"
                    );
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = passwd;
            }
            catch (Exception e) 
            {
                MessageBox.Show("Ошибка регистрации пользователя\nПричина: " + e.Message);
            }
            return false;
        }
    }
}
