namespace NotizenApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            EditEntry.home = true;
            Application.Run(new Navbar());
            /*string dir = @"C:/und|haben|sie|es|gemerkt|ist|in|der|program|cs";
            if (Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }*/
        }
    }
}