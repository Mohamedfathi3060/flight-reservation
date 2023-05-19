using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myProject
{
    public partial class Login : Form
    {
        public Dictionary<string, string> DATA = new Dictionary<string, string>();

        public Login()
        {
            string connString = "Data Source = GAGO; Initial Catalog=BikeStores; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string query = "select * from production.brands";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DATA[reader.GetValue(0) + ""] = reader.GetValue(1) + "";
            }
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f();
        }

        void f()
        {
            if (DATA[textBox1.Text] == textBox2.Text)
            {
                MessageBox.Show("Nice");
            }
            else
            {
                MessageBox.Show("Wrong");

            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            Program.fixedLogin.Hide();
        }
    }
}
