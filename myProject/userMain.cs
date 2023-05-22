//            private void button2_Click(object sender, EventArgs e)
//       {
//            this.Close();
//            myReservations my = new myReservations();
//            my.Show();
//}

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
    public partial class userMain : Form
    {
        static public DataTable dt = new DataTable();
        public userMain()
        {
            InitializeComponent();
            loadToDataTable();
        }

        public void loadToDataTable()
        {

            SqlDataAdapter ad = Functions.makeQuery("select * from flight");
            dt.Clear();
            ad.Fill(dt);
            dataGridView1.DataSource = new DataTable();
            dataGridView1.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Book book = new Book();
            book.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            myReservations my = new myReservations();
            my.Show();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.fixedLogin.Show();
        }
    }
}