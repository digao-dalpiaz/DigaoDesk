using System;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Vars.FrmMainObj = new();
            Application.Run(Vars.FrmMainObj);
        }
    }
}
