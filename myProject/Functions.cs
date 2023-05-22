using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProject
{
    internal class Functions
    {
        static public SqlConnection? conn;
        static public SqlDataReader? reader;

        static public MySqlConnection? Myconn;


        //static public void connectToDatabase()
        //{
        //    const string connString = "Data Source = GAGO; Initial Catalog=Flight; Integrated Security=true";
        //    conn  = new SqlConnection(connString);
        //    conn.Open();            

        //}
        static public void connect()
        {
            string server = "sql7.freesqldatabase.com";
            string database = "sql7620169";
            string username = "sql7620169";
            string password = "pEfhUzwEeF";
            string connetionString = "server=" + server + ";database=" + database + ";uid=" + username + ";pwd=" + password + ";";
            Myconn = new MySqlConnection(connetionString);
            try
            {
                Myconn.Open();
                MessageBox.Show("Connection Open ! ");
                Myconn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message.ToString());
            }

        }

        static public SqlDataAdapter makeQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            return new SqlDataAdapter(query, conn);

        }

        static public void MymakeQuery(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, Myconn);
            cmd.ExecuteNonQuery();

        }




    }
}
