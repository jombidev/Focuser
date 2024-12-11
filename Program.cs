using System;
using System.Threading;
using System.Windows.Forms;

namespace Focuser
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.GetDomain().UnhandledException += (sender, e) =>
            {
                Console.WriteLine(e.ExceptionObject.ToString());
                Console.WriteLine("no");
            };

            Console.CancelKeyPress += (sender, e) =>
            {
                e.Cancel = true;
                Console.WriteLine("SIGINT");
            };
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FocuserStart());
        }
    }
}