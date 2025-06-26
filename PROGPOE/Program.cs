namespace PROGPOE
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<string> nameDisplay = new List<string>();
            List<string> Descriptions = new List<string>();
            List<DateTime> Dates = new List<DateTime>();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new NavigationMenu(nameDisplay, Descriptions, Dates));
        }
    }
}