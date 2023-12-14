using WinFormsApp4.data;
using System.Collections.Specialized;


namespace WinFormsApp4
{
    internal static class Program
    {
        private static string filePath = @"C:\Users\Omar\imageSource\repos\SMSS2\WinFormsApp4\bin\Logger.txt";
        public static StreamWriter writer = new StreamWriter(filePath, true);

        public static void Log(string message)
        {
            writer.WriteLine(message);
            writer.Flush();
        }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // tomize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            
            ApplicationConfiguration.Initialize();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login_Page());

        }
    }
}