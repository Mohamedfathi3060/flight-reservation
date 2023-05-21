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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flightidinput.Text != "" && portinput.Text != "" && ssninput.Text != "" && firstinput.Text != "" && lastinput.Text != ""
                && ageinput.Value > 0 && (maleinput.Checked != femaleinput.Checked))
            {
                SqlDataAdapter id = Functions.makeQuery("select count(bookID) from reservation");
                int bookID = (int)id.SelectCommand.ExecuteScalar() + 1;
                Functions.makeQuery("insert into passenger values (" + "'" + portinput.Text + "'" + "," + "'" + ssninput.Text + "'" + "," + "'" + ((maleinput.Checked == true) ? "male" : "female") + "'" + "," + "'" + ageinput.Value + "'" + "," + "'" + firstinput.Text + "'" + "," + "'" + lastinput.Text + "'" + ")");
                Functions.makeQuery("insert into reservation values (" + "'" + bookID + "'" + "," + "'" + flightidinput.Text + "'" + "," + "'" + Program.primKey + "'" + "," + "'" + portinput.Text + "')");
                MessageBox.Show("Reservation taken successfully");
                SqlDataAdapter ad = Functions.makeQuery("select bookID,fligtID from reservation where (UserName = " + "'" + Program.primKey + "'" + ")");
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
    }
}
