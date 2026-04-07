using WekaWeka.Data;
using WekaWeka.Utils;

namespace WekaWeka
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            DbInitializer.Initialize(); // 👈 add this

            SessionManager.LoadSession();

            if (SessionManager.IsLoggedIn)
                Application.Run(new MainForm());
            else
                Application.Run(new LoginForm());
        }
    }
}