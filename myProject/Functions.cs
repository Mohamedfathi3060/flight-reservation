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

        static public void connectToDatabase()
        {
            const string connString = "Data Source = DESKTOP-QI282G3; Initial Catalog=Flight; Integrated Security=true";
            conn  = new SqlConnection(connString);
            conn.Open();            

        }
        
        static public SqlDataAdapter makeQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            return new SqlDataAdapter(query, conn);

        }

       


    }
}
