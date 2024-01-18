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
                    Utils.Navigate(Vars.DIGAODALPIAZ_SURVEY_LINK);
                }

                r.SetValue(askedKey, 1);
            }
        }

    }
}
