using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace myProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        

        
        static void Main()
        {
            //curr = new Login();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Functions.connect();
            Functions.MymakeQuery("create table flight(flightId varchar(10) )");
           // ApplicationConfiguration.Initialize();
           //Application.EnableVisualStyles();
            // Functions.connectToDatabase();
            //Application.Run(fixedLogin);
        }
        



        public static Form fixedLogin = new Login();
        static public string? primKey;
        static public string? pass;
        //static public string fname;
        //static public string lname;




    }
}