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

namespace myProject
{
    public partial class stats : Form
    {
        DataTable dtflight = new DataTable();

        int nflight;
        int naicrft;
        public stats()
        {
            InitializeComponent();
            load();

        }

        void load()
        {
            string query = "select   f.fligtID  ,  f.dates  ,  f.Sources  , f.Destination,  count(r.bookID) as 'number of passengers' " +
                "from flight as f left outer join reservation as r on f.fligtID = r.fligtID " +
                "group by f.fligtID  ,  f.dates  ,  f.Sources  , f.Destination;";
            SqlDataAdapter ad = Functions.makeQuery(query);
            ad.Fill(dtflight);
            dataGridView1.DataSource = new DataTable();
            dataGridView1.DataSource = dtflight;

            SqlDataAdapter d = Functions.makeQuery("select count(*) from flight");
            nflight = (int)d.SelectCommand.ExecuteScalar();
            label5.Text = nflight.ToString();

            SqlDataAdapter c = Functions.makeQuery("select count(*) from aircraft");
            naicrft = (int)c.SelectCommand.ExecuteScalar();
            label6.Text = naicrft.ToString();


        }
        private void Flights_Click(object sender, EventArgs e)
        {

            this.Close();
            adminFlight x = new adminFlight();
            x.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void aircraft_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminAircraft x = new AdminAircraft();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.fixedLogin.Show();
        }
    }
}
