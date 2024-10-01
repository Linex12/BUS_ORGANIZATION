namespace BUS_ORGANIZATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            logpanel.Hide();
            regpanel.Show();
        }

        private void goback_Click(object sender, EventArgs e)
        {
            logpanel.Show();
            regpanel.Hide();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            String user = ltlogin.Text;
            String passwd = ltpasswd.Text;
            MySQLdb mySQLdb = new MySQLdb();
        }
    }
}
