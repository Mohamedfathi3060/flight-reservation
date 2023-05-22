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
    public partial class myReservations : Form
    {
        static public DataTable dt = new DataTable();

        public myReservations()
        {
            InitializeComponent();
            loadToDataTable();
        }
        public void loadToDataTable()
        {

            

            SqlDataAdapter ad = Functions.makeQuery
                ("select r.bookID , passenger.firstName + ' ' + passenger.lastName as [Full Name], f.fligtID,f.Dates,f.Sources,f.Destination,f.class   " +
                "from flight as f inner join reservation as r on r.fligtID = f.fligtID" +
                " inner join passenger on passenger.passportnumber = r.passportnumber  "
                + "where (UserName = " + "'" + Program.primKey + "'" + ")");

            dt.Clear();
            ad.Fill(dt);/*must to overwrite the data in our dt*/
            dataGridView1.DataSource = new DataTable();
            dataGridView1.DataSource = dt;
        }

        public bool searchFlightID(string xx)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][2].ToString() == xx)
                {
                    return true;
                }
            }
            return false;
        }

        public bool searchBookID(string x)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == x)
                {
                    return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill in all the fields");
            }
            else
            {
                if (searchFlightID(textBox1.Text.ToString()) && searchBookID(textBox2.Text.ToString()))
                {
                    DialogResult Value = MessageBox.Show("Are You Sure You Want to Cancel Your Reservation?", "Cancel Reservation", MessageBoxButtons.YesNo);
                    if (Value == DialogResult.Yes)
                    {
                        Functions.makeQuery("delete from reservation where (bookID = " + "'" + textBox2.Text + "'" + ")");
                        MessageBox.Show("Reservation deleted successfully");
                        loadToDataTable();
                    }
                }
                else
                    MessageBox.Show("Reservation not found");
            }
        }

        private void bookbt_Click(object sender, EventArgs e)
        {
            this.Close();
            Book book = new Book();
            book.Show();
        }

        private void flightsbt_Click(object sender, EventArgs e)
        {
            this.Close();
            userMain userMain = new userMain();
            userMain.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.primKey = "";
            Program.fixedLogin.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
