using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myProject
{
    public partial class Book : Form
    {
        static public DataTable dt = new DataTable();
        static public DataTable ft = new DataTable();

        public void loadToPassengerData()
        {
            SqlDataAdapter ad = Functions.makeQuery("select * from passenger");
            ad.Fill(dt);/*must to overwrite the data in our dt*/
        }
        public void loadToFlightData()
        {
            SqlDataAdapter ad = Functions.makeQuery("select * from reservation");
            ad.Fill(ft);/*must to overwrite the data in our dt*/
        }
        public Book()
        {
            InitializeComponent();
            loadToPassengerData();
            loadToFlightData();
        }
        bool checkPassengerPassportnumber(string givenId)
        {
            foreach (DataRow row in dt.Rows)
            {

                if (row[0].ToString() == givenId)
                {
                    MessageBox.Show("i found this Passportnumber");
                    return false;
                }
            }
            return true;
        }
        bool checkflightid(string pport, string id)
        {
            foreach (DataRow row in ft.Rows)
            {

                if (row[1].ToString() == id && row[3].ToString() == pport)
                {
                    MessageBox.Show("i found this flight id");
                    return false;
                }
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (flightidinput.Text != "" && portinput.Text != "" && ssninput.Text != "" && firstinput.Text != "" && lastinput.Text != ""
                && ageinput.Value > 0 && (maleinput.Checked != femaleinput.Checked))
            {
                if (checkPassengerPassportnumber(portinput.Text))
                {
                    SqlDataAdapter id = Functions.makeQuery("select count(bookID) from reservation");
                    int bookID = (int)id.SelectCommand.ExecuteScalar() + 1;
                    Functions.makeQuery("insert into passenger values (" + "'" + portinput.Text + "'" + "," + "'" + ssninput.Text + "'" + "," + "'" + ((maleinput.Checked == true) ? "male" : "female") + "'" + "," + "'" + ageinput.Value + "'" + "," + "'" + firstinput.Text + "'" + "," + "'" + lastinput.Text + "'" + ")");
                    Functions.makeQuery("insert into reservation values (" + "'" + bookID + "'" + "," + "'" + flightidinput.Text + "'" + "," + "'" + Program.primKey + "'" + "," + "'" + portinput.Text + "')");
                    MessageBox.Show("Reservation taken successfully");
                    SqlDataAdapter ad = Functions.makeQuery("select bookID,fligtID from reservation where (UserName = " + "'" + Program.primKey + "'" + ")");

                }
                else
                {
                    if (checkflightid(portinput.Text, flightidinput.Text))
                    {
                        SqlDataAdapter id = Functions.makeQuery("select count(bookID) from reservation");
                        int bookID = (int)id.SelectCommand.ExecuteScalar() + 1;
                        Functions.makeQuery("insert into reservation values (" + "'" + bookID + "'" + "," + "'" + flightidinput.Text + "'" + "," + "'" + Program.primKey + "'" + "," + "'" + portinput.Text + "')");
                        MessageBox.Show("Reservation taken successfully");
                        SqlDataAdapter ad = Functions.makeQuery("select bookID,fligtID from reservation where (UserName = " + "'" + Program.primKey + "'" + ")");

                    }
                }
            }
            else
                MessageBox.Show("Please fill in all the fields");
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            userMain userMain = new userMain();
            userMain.Show();
        }

        private void bookbt_Click(object sender, EventArgs e)
        {
            this.Close();
            myReservations my = new myReservations();
            my.Show();
        }

        private void flightsbt_Click(object sender, EventArgs e)
        {
            this.Close();
            userMain userMain = new userMain();
            userMain.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void firstinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void lastinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.fixedLogin.Show();
        }
    }
}
