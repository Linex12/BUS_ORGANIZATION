using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;

namespace BUS_ORGANIZATION
{
    internal class MySQLdb
    {
        MySqlConnection connection;
        static string host = "localhost";
        static string port = "3306";
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
                if (!Open()) {
                    return false;
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                DataTable table = new DataTable();
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM user WHERE username = @login AND password = @passwd",
                    connection);
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = passwd;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    Close();
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
                if (!Open())
                {
                    return false;
                }
                if (passwd != passwdconf)
                {
                    throw new Exception("Passwords do not match");
                }
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO user (username, password) VALUES (@login, @passwd)",
                    connection);
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = passwd;
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт был создан");
                else
                    throw new Exception("Incorrect SQL Query");
                Close();
                return true;
            }
            catch (Exception e) 
            {
                MessageBox.Show("Ошибка регистрации пользователя\nПричина: " + e.Message);
            }
            Close();
            return false;
        }
        public bool PrintTable(string tablename, DataTable table)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM "+tablename,
                    connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Данные не заполнены\nПричина: " + e.Message);
            }
            Close();
            return false;
        }
        public bool DeleteRow(string table, string column, string id)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlCommand command = new MySqlCommand(
                    "DELETE FROM " + table + " WHERE " + column + "=" + id,
                    connection);
                if (command.ExecuteNonQuery() != 1)
                    throw new Exception("Строки не существует в базе данных");
                Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка удаления строки\nПричина: " + e.Message);
            }
            Close();
            return false;
        }
        public bool InsertRow(string table, string count)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlCommand command1 = new MySqlCommand(
                    "ALTER TABLE " + table + " AUTO_INCREMENT = " + count,
                    connection);
                if (command1.ExecuteNonQuery() != 0) 
                    throw new Exception("что-то пошло не так при обнулении AUTO_INCREMENT");
                MySqlCommand command2 = new MySqlCommand(
                    "INSERT INTO "+table+" DEFAULT VALUES",
                    connection);
                if (command2.ExecuteNonQuery() != 1)
                    throw new Exception("что-то пошло не так при добавлении строки");
                Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка добавления строки\nПричина: " + e.Message);
            }
            Close();
            return false;
        }
        public bool UpdateRow(string table,string primarykey, string column, string id, string value)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlCommand command = new MySqlCommand(
                    "UPDATE " + table + " SET " + column + "="+ value +" WHERE " + primarykey + "=" + id,
                    connection);
                if (command.ExecuteNonQuery() != 1)
                    throw new Exception("Строки не существует в базе данных");
                Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка изменения строки\nПричина: " + e.Message);
            }
            Close();
            return false;
        }
        public bool ExecuteSQLScript(string script)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlCommand command = new MySqlCommand(
                    script,
                    connection);
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Команда выполнена успешно\n Текст команды:\n" + script);
                else
                    throw new Exception("Script is incorrect. Text\n" + script);
                Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка изменения строки\nПричина: " + e.Message);
            }
            Close();
            return false;
        }
    }
}
