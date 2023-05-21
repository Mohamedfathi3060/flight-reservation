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

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Functions.connectToDatabase();
            Application.Run(fixedLogin);

        }

        public static Form fixedLogin = new Login();

       
            static public string primKey = "20210348";
        static public string? pass;
        //static public string fname;
        //static public string lname;




    }
}