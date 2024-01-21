namespace DigaoDeskApp
{
    public partial class FrmWait : Form
    {

        private static FrmWait _instance;

        public FrmWait()
        {
            InitializeComponent();
        }

        public static void Start(string text)
        {
            if (_instance == null)
            {
                _instance = new();
            }
            _instance.lbInfo.Text = text;
            _instance.Show();
            _instance.Refresh();
        }

        public static void Stop()
        {
            if (_instance != null)
            {
                _instance.Close();
                _instance = null;
            }
        }

    }
}
