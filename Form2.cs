using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_ORGANIZATION
{
    public partial class Form2 : Form
    {
        private String tablename;
        private String primarykey;
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    tablename = "user";
                    primarykey = "userid";
                    break;
                case 1:
                    tablename = "roles";
                    primarykey = "roleid";
                    break;
                case 2:
                    tablename = "worker";
                    primarykey = "idWorker";
                    break;
                case 3:
                    tablename = "position";
                    primarykey = "idPosition";
                    break;
                case 4:
                    tablename = "category";
                    primarykey = "idCategory";
                    break;
                case 5:
                    tablename = "bus";
                    primarykey = "idBus";
                    break;
                case 6:
                    tablename = "bus_stop";
                    primarykey = "idBusStop";
                    break;
                case 7:
                    tablename = "route";
                    primarykey = "idRoute";
                    break;
                case 8:
                    tablename = "transportation";
                    primarykey = "idTransportation";
                    break;
            }
            MySQLdb mySQLdb = new MySQLdb();
            DataTable dt = new DataTable();
            mySQLdb.PrintTable(tablename, dt);
            dataGridView1.DataSource = dt;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            String id = dataGridView1.Rows[index].Cells[primarykey].Value.ToString();
            MySQLdb mySQLdb = new MySQLdb();
            if (!mySQLdb.DeleteRow(tablename, primarykey, id))
                e.Cancel = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            String column = dataGridView1.Columns[columnindex].HeaderText;
            String id = dataGridView1.Rows[rowindex].Cells[primarykey].Value.ToString();
            String value = dataGridView1.Rows[rowindex].Cells[columnindex].Value.ToString();
            MySQLdb mySQLdb = new MySQLdb();
            mySQLdb.UpdateRow(tablename, primarykey, column, id, value);
        }

        private void addrow_Click(object sender, EventArgs e)
        {
            String count = dataGridView1.RowCount.ToString();
            MySQLdb mySQLdb = new MySQLdb();
            mySQLdb.InsertRow(tablename, count);
            DataTable dt = new DataTable();
            mySQLdb.PrintTable(tablename, dt);
            dataGridView1.DataSource = dt;
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            MySQLdb mySQLdb = new MySQLdb();
            DataTable dt = new DataTable();
            mySQLdb.PrintTable(tablename, dt);
            dataGridView1.DataSource = dt;
        }
    }
}