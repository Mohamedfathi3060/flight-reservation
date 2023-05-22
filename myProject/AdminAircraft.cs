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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace myProject
{
    public partial class AdminAircraft : Form
    {
        static public DataTable dt = new DataTable();


        public AdminAircraft()
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

            SqlDataAdapter ad = Functions.makeQuery("select * from aircraft");
            dt.Clear();
            ad.Fill(dt);/*must to overwrite the data in our dt*/
            dataGridView1.DataSource = new DataTable();
            dataGridView1.DataSource = dt;
        }
        bool checkAircraftId(string givenId)
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
        bool checkAircraftSeats(string givenSeats)
        {
            for (int i = 0; i < givenSeats.Length; i++)
            {
                if (char.IsDigit(givenSeats[i]))
                {

                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AdminAircraft_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
        }


        private void add_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxsrc_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "" || textBoxSeats.Text == "" || textBoxKind.Text == "" || textBoxSeats.Text == "")
            {
                MessageBox.Show("incomplete data .. there is empty input", "empty form", MessageBoxButtons.OK);
                textBoxID.Text = "";
                textBoxKind.Text = "";
                textBoxSeats.Text = "";
                textBoxSize.Text = "";
                return;
            }
            if (!checkAircraftSeats(textBoxSeats.Text))
            {
                MessageBox.Show("seats must be number.", "wrong data", MessageBoxButtons.OK);
                textBoxID.Text = "";
                textBoxKind.Text = "";
                textBoxSeats.Text = "";
                textBoxSize.Text = "";
                return;
            }
            if (!checkAircraftId(textBoxID.Text))
            {

                /*insert in database*/
                insert("update  aircraft " +
                    "set " +

                    "Kind = '" +
                    textBoxKind.Text.ToString() +
                    "' , " +
                    "seats = '" +
                    textBoxSeats.Text.ToString() +
                    "' , " +
                    "size = '"
                    +
                    textBoxSize.Text.ToString() +
                     "' " +
                    "where AircrftID = " + textBoxID.Text.ToString() + " "

                    );

                /*update the dt*/
                MessageBox.Show("i have already update this aircraft");



            }
            else
            {
                MessageBox.Show("aircraft is added before..!", "", MessageBoxButtons.OK);

            }
            textBoxID.Text = "";
            textBoxKind.Text = "";
            textBoxSeats.Text = "";
            textBoxSize.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            adminFlight adminFlight = new adminFlight();
            adminFlight.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Program.fixedLogin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxID.Text == "" || textBoxSeats.Text == "" || textBoxKind.Text == "" || textBoxSeats.Text == "")
            {
                MessageBox.Show("incomplete data .. there is empty input", "empty form", MessageBoxButtons.OK);
                textBoxID.Text = "";
                textBoxKind.Text = "";
                textBoxSeats.Text = "";
                textBoxSize.Text = "";
                return;
            }
            if (!checkAircraftSeats(textBoxSeats.Text))
            {
                MessageBox.Show("seats must be number.", "wrong data", MessageBoxButtons.OK);
                textBoxID.Text = "";
                textBoxKind.Text = "";
                textBoxSeats.Text = "";
                textBoxSize.Text = "";
                return;
            }
            if (checkAircraftId(textBoxID.Text))
            {

                /*insert in database*/
                insert("insert into aircraft " +
                    "values( '" +
                    textBoxID.Text.ToString() +
                    "' , '" +
                    textBoxKind.Text.ToString() +
                    "' , '" +
                    textBoxSeats.Text.ToString() +
                    "' , '" +
                    textBoxSize.Text.ToString() +
                    "' )");

                /*update the dt*/
                MessageBox.Show("i have already insert this aircraft");



            }
            else
            {
                MessageBox.Show("aircraft is added before..!", "", MessageBoxButtons.OK);

            }
            textBoxID.Text = "";
            textBoxKind.Text = "";
            textBoxSeats.Text = "";
            textBoxSize.Text = "";

        }
    }
}
