using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_ORGANIZATION
{
    public partial class Form2 : Form
    {
        private string tablename;
        private string primarykey;
        private int key_count;
        private uint roleid;
        private int selectedindexrow;
        private int selectedindexcol;
        private string[] selectedvalues;
        private uint[] needroles;
        public Form2(uint roleid)
        {
            InitializeComponent();
            this.roleid = roleid;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    tablename = "user";
                    primarykey = "userid";
                    needroles = [1];
                    key_count = 1;
                    break;
                case 1:
                    tablename = "roles";
                    primarykey = "roleid";
                    needroles = [1];
                    key_count = 1;
                    break;
                case 2:
                    tablename = "worker";
                    primarykey = "idWorker";
                    needroles = [1];
                    key_count = 1;
                    break;
                case 3:
                    tablename = "position";
                    primarykey = "idPosition";
                    needroles = [1];
                    key_count = 1;
                    break;
                case 4:
                    tablename = "category";
                    primarykey = "idCategory";
                    needroles = [1];
                    key_count = 1;
                    break;
                case 5:
                    tablename = "bus";
                    primarykey = "idBus";
                    needroles = [1, 2];
                    key_count = 1;
                    break;
                case 6:
                    tablename = "bus_stop";
                    primarykey = "idBusStop";
                    needroles = [1, 2];
                    key_count = 1;
                    break;
                case 7:
                    tablename = "route";
                    primarykey = "idRoute";
                    needroles = [1, 2];
                    key_count = 1;
                    break;
                case 8:
                    tablename = "transportation";
                    primarykey = "idTransportation";
                    needroles = [1, 2, 3];
                    key_count = 1;
                    break;
                case 9:
                    tablename = "account";
                    primarykey = "idAccount";
                    needroles = [1, 3];
                    key_count = 1;
                    break;
                case 10:
                    tablename = "worker_position_category";
                    key_count = 3;
                    needroles = [1];
                    break;
                case 11:
                    tablename = "route_composition";
                    key_count = 2;
                    needroles = [1, 2];
                    break;
            }
            if (needroles.Contains<uint>(roleid))
            {
                MySQLdb mySQLdb = new MySQLdb();
                DataTable dt = new DataTable();
                mySQLdb.PrintTable(tablename, dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Нет доступа к таблице");
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            MySQLdb mySQLdb = new MySQLdb();
            if (key_count == 1)
            {
                if (!mySQLdb.DeleteRow(tablename, primarykey, selectedvalues[0]))
                    e.Cancel = true;
            }
            else if (key_count == 2)
            {
                if (!mySQLdb.DeleteRow2keys(tablename, selectedvalues[0], selectedvalues[1]))
                    e.Cancel = true;
            }
            else if (key_count == 3)
            {
                if (!mySQLdb.DeleteRow3keys(tablename, selectedvalues[0], selectedvalues[1], selectedvalues[2]))
                    e.Cancel = true;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String column = dataGridView1.Columns[selectedindexcol].HeaderText;
            String value = dataGridView1.Rows[selectedindexrow].Cells[selectedindexcol].Value.ToString();
            MySQLdb mySQLdb = new MySQLdb();
            if (key_count == 1)
            {
                mySQLdb.UpdateRow(tablename, primarykey, column, selectedvalues[0], value);
            }
            else if (key_count == 2)
            {
                mySQLdb.UpdateRow2keys(tablename, selectedvalues[0], selectedvalues[1], column, value);
            }
            else if (key_count == 3)
            {
                mySQLdb.UpdateRow3keys(tablename, selectedvalues[0], selectedvalues[1], selectedvalues[2], column, value);
            }
        }

        private void addrow_Click(object sender, EventArgs e)
        {
            String count = dataGridView1.RowCount.ToString();
            MySQLdb mySQLdb = new MySQLdb();
            if (textBox5.Text == "")
            {
                mySQLdb.InsertRow(tablename, count);
            }
            else
            {
                mySQLdb.InsertRow(tablename, count, textBox5.Text);
            }
            DataTable dt = new DataTable();
            mySQLdb.PrintTable(tablename, dt);
            dataGridView1.DataSource = dt;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            if (needroles.Contains<uint>(roleid))
            {
                MySQLdb mySQLdb = new MySQLdb();
                DataTable dt = new DataTable();
                mySQLdb.PrintTable(tablename, dt);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Нет доступа к таблице");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (needroles.Contains<uint>(roleid))
            {
                MySQLdb mySQLdb = new MySQLdb();
                DataTable dt = new DataTable();
                mySQLdb.PrintTableWithParameters(tablename, dt, textBox1.Text);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Нет доступа к таблице");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySQLdb mySQLdb = new MySQLdb();
            DataTable dt = new DataTable();
            mySQLdb.PrintProcedureResult(textBox2.Text, textBox3.Text, dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySQLdb mySQLdb = new MySQLdb();
            mySQLdb.ExecuteSQLScript(textBox4.Text);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                selectedindexrow = dataGridView1.CurrentCell.RowIndex;
                selectedindexcol = dataGridView1.CurrentCell.ColumnIndex;
                if (key_count == 1)
                    selectedvalues = [dataGridView1.CurrentRow.Cells[primarykey].Value.ToString()];
                else if (key_count == 2)
                    selectedvalues = [
                        dataGridView1.CurrentRow.Cells["idRoute"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["idBusStop"].Value.ToString()
                        ];
                else if (key_count == 3)
                    selectedvalues = [
                        dataGridView1.CurrentRow.Cells["idWorker"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["idPosition"].Value.ToString(),
                    dataGridView1.CurrentRow.Cells["idCategory"].Value.ToString()
                        ];
            }
            catch (Exception ex) 
            { 
            }
        }
    }
}