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
        public bool CheckLogin(String login, String passwd, out uint roleid)
        {
            try
            {
                if (!Open()) {
                    roleid = 0;
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
                    MySqlCommand command2 = new MySqlCommand(
                    "SELECT roleid FROM user WHERE username = @login AND password = @passwd",
                    connection);
                    command2.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                    command2.Parameters.Add("@passwd", MySqlDbType.VarChar).Value = passwd;
                    roleid = (uint)command2.ExecuteScalar();
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
            roleid = 0;
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
                    "INSERT INTO user (username, password, roleid) VALUES (@login, @passwd, 2)",
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
        public bool PrintTableWithParameters(string tablename, DataTable table, string text)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(
                    "SELECT * FROM " + tablename + " WHERE " + text,
                    connection);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Таблица не высвечена\nПричина: " + e.Message);
            }
            Close();
            return false;
        }

        public bool PrintProcedureResult(string bus_stop, string route, DataTable table)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand(
                    "call BusStopInRoute(@dn, @rid)",
                    connection);
                command.Parameters.Add("@dn", MySqlDbType.VarChar).Value = bus_stop;
                command.Parameters.Add("@rid", MySqlDbType.Int32).Value = route;
                adapter.SelectCommand = command;
                adapter.Fill(table);
                Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Таблица не высвечена\nПричина: " + e.Message);
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
        public bool DeleteRow2keys(string table, string id1, string id2)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlCommand command = new MySqlCommand(
                    "DELETE FROM " + table + " WHERE idRoute = " + id1 + " AND idBusStop=" + id2,
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
        public bool DeleteRow3keys(string table, string id1, string id2, string id3)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlCommand command = new MySqlCommand(
                    "DELETE FROM " + table + " WHERE idWorker = " + id1 + " AND idPosition=" + id2 + " AND idCategory=" + id3,
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
                try
                {
                    MySqlCommand command = new MySqlCommand(
                        "UPDATE " + table + " SET " + column + "=" + value + " WHERE " + primarykey + "=" + id,
                        connection);
                    if (command.ExecuteNonQuery() != 1)
                        throw new Exception("Строки не существует в базе данных");
                }
                catch (Exception e)
                {
                    MySqlCommand command = new MySqlCommand(
                        "UPDATE " + table + " SET " + column + "=\"" + value + "\" WHERE " + primarykey + "=" + id,
                        connection);
                    if (command.ExecuteNonQuery() != 1)
                        throw new Exception("Строки не существует в базе данных");
                }
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
        public bool UpdateRow2keys(string table, string id1, string id2, string column, string value)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlCommand command = new MySqlCommand(
                    "UPDATE " + table + " SET " + column + "=" + value + " WHERE idRoute =" + id1 + " AND idBusStop ="+id2,
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
        public bool UpdateRow3keys(string table, string id1, string id2, string id3, string column, string value)
        {
            try
            {
                if (!Open())
                {
                    return false;
                }
                MySqlCommand command = new MySqlCommand(
                    "UPDATE " + table + " SET " + column + "=" + value + " WHERE idWorker =" + id1 + " AND idPosition =" + id2 +
                    " AND idCategory=" + id3,
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
                command.ExecuteNonQuery();
                Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка выполнения скрипта\nПричина: " + e.Message);
            }
            Close();
            return false;
        }
    }
}
