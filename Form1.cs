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
            MySQLdb db = new MySQLdb();
            if (db.CheckLogin(user, passwd, out uint roleid)) {
                Hide();
                Form2 form2 = new Form2(roleid);
                form2.Show();
            }
        }

        private void registeracc_Click(object sender, EventArgs e)
        {
            String user = rtlogin.Text;
            String passwd = rtpasswd.Text;
            String passwdconf = rtpasswdconf.Text;
            MySQLdb db = new MySQLdb();
            db.AddUser(user, passwd, passwdconf);
        }
    }
}
