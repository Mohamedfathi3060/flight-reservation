using System;
using System.Collections;
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
    public partial class adminFlight : Form
    {
        static public DataTable dt = new DataTable();


        public adminFlight()
        {
            InitializeComponent();

            loadToDataTable();

        }

        public void insert(string query)
        {

            Functions.makeQuery(query); /*for insert */
            loadToDataTable();

        }



        public void loadToDataTable()
        {

            SqlDataAdapter ad = Functions.makeQuery("select * from flight");
            dt.Clear();
            ad.Fill(dt);/*must to overwrite the data in our dt*/
            dataGridView1.DataSource = new DataTable();
            dataGridView1.DataSource = dt;
        }


        private void adminFlight_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void textBoxsrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text == "" || textBoxdest.Text == "" || textBoxsrc.Text == "")
            {
                MessageBox.Show("incomplete data .. there is empty input", "empty form", MessageBoxButtons.OK);
                return;
            }
            if (checkFlightId(textBoxID.Text))
            {
                /*insert in database*/
                insert("insert into flight " +
                    "values( '" +
                    textBoxID.Text.ToString() +
                    "' , '" +
                    dateTimePicker1.Value +
                    "' , '" +
                    textBoxsrc.Text.ToString() +
                    "' , '" +
                    textBoxdest.Text.ToString() +
                    "' , '" +
                    comboBox1.Text.ToString() +
                    "' , '" +
                    textBoxflightId.Text.ToString() +
                    "' , '" +
                    Program.primKey.ToString() +
                    "' )");

                /*update the dt*/
                MessageBox.Show("i have already insert this flight");

                // will be updates automaticly


            }
            else
            {
                MessageBox.Show("flight is added before..! check availble flights", "", MessageBoxButtons.OK);

            }

        }
        bool checkFlightId(string givenId)
        {
            foreach (DataRow row in dt.Rows)
            {
                if (row[0].ToString() == givenId)
                {
                    MessageBox.Show("i found this id");
                    return false;
                }
            }
            MessageBox.Show("i dont found this id");

            return true;

        }

        private void update_Click_1(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxdest.Text == "" || textBoxsrc.Text == "")
            {
                MessageBox.Show("incomplete data .. there is empty input", "empty form", MessageBoxButtons.OK);
                return;
            }
            if (!checkFlightId(textBoxID.Text))
            {
                /*update in database*/

                insert("update  flight " +
                   "set " +

                   "Dates = '" +
                   dateTimePicker1.Value +
                   "' , " +
                   "Sources = '" +
                   textBoxsrc.Text.ToString() +
                   "' , " +
                   "Destination = '"
                   +
                   textBoxdest.Text.ToString() +
                   "' ," +
                   "class = '"
                   +
                   comboBox1.Text.ToString() +
                   "' ," +
                   "AircraftIDs = '"
                   +
                   textBoxflightId.Text.ToString() +
                   "' " +
                   "where fligtID = " + textBoxID.Text.ToString() + " "

                   );

                /*update the dt*/

                MessageBox.Show("i have already update that flight");


                /*update the dt*/

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AdminAircraft aircraft = new AdminAircraft();
            aircraft.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
            Program.fixedLogin.Show();
        }
    }
}

