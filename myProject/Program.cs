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
            Application.Run(new adminFlight());

        }

        public static Form fixedLogin = new Login();


    }
}