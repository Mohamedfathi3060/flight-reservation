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

        static public DataTable admindt = new DataTable();
        static public DataTable customerdt = new DataTable();

        public Login()

        {
            string query = "select SSN , Passwords from admins ";
            SqlDataAdapter adapter =  Functions.makeQuery(query);

            string secquery = "select UserName , Passwords from customer ";
            SqlDataAdapter secadapter = Functions.makeQuery(secquery);
            loadFromReader(adapter,secadapter);

            InitializeComponent();
        }
        void loadFromReader(SqlDataAdapter adminmadapter , SqlDataAdapter cusadapter)
        {

            adminmadapter.Fill(admindt);
            cusadapter.Fill(customerdt);



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
            if (textBox2.Text == "" || textBox1.Text == ""){
                MessageBox.Show("empty form" ,"Error meaasge",MessageBoxButtons.OK);
            }
            else if ( searchinadmins(textBox1.Text , textBox2.Text) )
            {
                /*  >>>>>>>>>>>>> I Am ADMIN <<<<<<<<<<<<<<<<  */
              DialogResult x =  MessageBox.Show("succsefully logined as Admin..!" , "" , MessageBoxButtons.OKCancel);


                if (x== DialogResult.OK)
                {
                    Program.primKey = textBox1.Text;
                    Program.pass = textBox2.Text;
                    MoveToadminFlight();
                }
            }
            else if (searchincustomers(textBox1.Text, textBox2.Text))
            {

                /*  >>>>>>>>>>>>> I Am Customer <<<<<<<<<<<<<<<<  */
                DialogResult x = MessageBox.Show("succsefully logined as customer..!", "", MessageBoxButtons.OKCancel);


                if (x == DialogResult.OK)
                {
                    Program.primKey = textBox1.Text;
                    Program.pass = textBox2.Text;


                    /*need implementaion*/
                    Movetocustomer();


                }
            }
            else
            {
                MessageBox.Show("Wrong user name or Password","",MessageBoxButtons.RetryCancel);
            }
        }
        static public bool searchinadmins(string ssn , string pass)
        {

            foreach(DataRow row in admindt.Rows)
            {
                if (row[0].ToString() == ssn && row[1].ToString() == pass)
                {
                    MessageBox.Show("i have found this ..!");
                    return true;
                }
            }
            MessageBox.Show("i don't found this ..!");

            return false;
        }
        static public bool searchincustomers(string username, string pass)
        {

            foreach (DataRow row in customerdt.Rows)
            {
                if (row[0].ToString() == username && row[1].ToString() == pass)
                {
                    MessageBox.Show("i have found this ..!");

                    return true;
                }
            }
            MessageBox.Show("i don't found this ..!");

            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MoveToRegister();
        }

        void MoveToRegister()
        {
            Register reg = new Register();
            reg.Show();
            Program.fixedLogin.Hide();
        }
        void MoveToadminFlight()
        {
            adminFlight f = new adminFlight();
            f.Show();
            Program.fixedLogin.Hide();
        }
        void Movetocustomer()
        {
            userMain f = new userMain();
            f.Show();
            Program.fixedLogin.Hide();
            /*Move me to customer PAge Plaeade*/
        }
    }
}
