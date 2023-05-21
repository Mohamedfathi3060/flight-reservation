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

            SqlDataAdapter ad = Functions.makeQuery("select bookID,fligtID from reservation where (UserName = " + "'" + Program.primKey + "'" + ")");
            dt.Clear();
            ad.Fill(dt);/*must to overwrite the data in our dt*/
            dataGridView1.DataSource = new DataTable();
            dataGridView1.DataSource = dt;
        }

        public bool searchFlightID()
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][1].ToString() == textBox1.Text)
                {
                    return true;
                }
            }
            return false;
        }

        public bool searchBookID()
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == textBox2.Text)
                {
                    return true;
                }
            }
            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Please fill in all the fields");
            else
            {
                if (searchFlightID() == true && searchBookID() == true)
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
    }
}
