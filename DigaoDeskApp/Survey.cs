using System.Diagnostics;

namespace DigaoDeskApp
{
    internal class Survey
    {

        private const string REGKEY = Vars.APP_REGKEY + @"\Survey";

        public static void Check()
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);

            const string askedKey = "Asked";

            int asked = (int)r.GetValue(askedKey, 0);

            if (asked == 0)
            {
                if (Messages.Question(Vars.Lang.SurveyQuestion))
                {
                    Process.Start("explorer", "https://digaodalpiaz.com/wp/digao-desk-usage/");
                }

                r.SetValue(askedKey, 1);
            }
        }

    }
}
