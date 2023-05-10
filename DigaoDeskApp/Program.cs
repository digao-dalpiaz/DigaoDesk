using System;
using System.Threading;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    static class Program
    {

        static Mutex mutex = new Mutex(true, "DigaoDeskApp");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EventAudit.Do("Starting program in: " + System.AppContext.BaseDirectory);
            EventAudit.Do("Version " + Vars.APP_VERSION);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (GitHubUpdater.CheckForUpdateExe()) return; //returns true when running from temporary path (updating process)

            Config.Load();
            LangEngine.Init();

            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                Messages.Error(Vars.Lang.AlreadyRunningMessage);
                return;
            }

            Vars.FrmMainObj = new();
            Application.Run(Vars.FrmMainObj);
        }

    }
}
