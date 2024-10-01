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
        static string database = "bus_org";
        static string user = "root";
        static string password = "password";
        public bool Open()
        {
            try
            {
                connection = new MySqlConnection(
                    "server=" + host +
                    ";database=" + database +
                    ";username=" + user +
                    ";password=" + password);
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
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                MySqlCommand command = new MySqlCommand("Сюда следует заменить на команду");
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
            return false;
        }
        public bool AddUser(String login, String passwd, String passwdconf)
        {
            try
            {

            }
            catch (Exception e) 
            {
                MessageBox.Show("Ошибка регистрации пользователя\nПричина: " + e.Message);
            }
            return false;
        }
    }
}
