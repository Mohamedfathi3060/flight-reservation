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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myProject
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            GC.Collect();
            Program.fixedLogin.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            if (textBoxfname.Text == "" || textBoxlname.Text == "" || textBoxpass.Text == "" || textBoxusername.Text == "" || (radioButton1.Checked == radioButton2.Checked))
            {
                MessageBox.Show("incomplete data .. there is empty input", "empty form", MessageBoxButtons.OK);
                return;
            }
            if (!Login.searchincustomers(textBoxusername.Text, textBoxpass.Text))
            {
                /*insert in database*/
                insert("insert into customer " +
                    "values( '" +
                    textBoxusername.Text.ToString() +
                    "' , '" +
                    textage.Text +
                    "' , '" +
                    (radioButton1.Checked == true? "Male":"Female")+
                    "' , '" +
                    textBoxpass.Text.ToString() +
                    "' , '" +
                    textBoxfname.Text.ToString() +
                    "' , '" +
                    textBoxlname.Text.ToString() +
                    "' )");

                /*update the dt*/
                MessageBox.Show("i have already insert this flight");

                // will be updates automaticly
            }
            else 
            {
                MessageBox.Show("this username is taken before..!");

            }
        }
        public void insert(string query)
        {
            Functions.makeQuery(query); /*for insert */

            /*update login dataTables*/
            string _query = "select SSN , Passwords from admins ";
            SqlDataAdapter adapter = Functions.makeQuery(_query);

            string secquery = "select UserName , Passwords from customer ";
            SqlDataAdapter secadapter = Functions.makeQuery(secquery);

            
            adapter.Fill(Login.admindt);
            secadapter.Fill(Login.customerdt);

        }

    }
}
