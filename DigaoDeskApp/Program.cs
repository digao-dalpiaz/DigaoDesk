namespace DigaoDeskApp
{
    static class Program
    {

        private static readonly Mutex mutex = new(true, "DigaoDeskApp");

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            EventAudit.Do("Starting program in: " + System.AppContext.BaseDirectory);
            EventAudit.Do("Version " + Vars.APP_VERSION);

            if (GitHubUpdater.CheckForUpdateExe()) return; //returns true when running from temporary path (updating process)

            Config.Load();
            LangEngine.Init();

            if (!mutex.WaitOne(TimeSpan.Zero, true))
            {
                Messages.Error(Vars.Lang.AlreadyRunningMessage);
                return;
            }

            if (Vars.IsConfigVersion1Converted) Messages.Info(Vars.Lang.MsgNewFeatureGitGroups);

            Vars.FrmMainObj = new();
            Application.Run(Vars.FrmMainObj);
        }

    }
}
