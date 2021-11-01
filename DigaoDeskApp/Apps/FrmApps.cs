using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmApps : Form
    {

        private const string REGKEY = Vars.APP_REGKEY + @"\Apps";

        private BindingSource _gridBind;
        private bool _updatingGrid;

        private int _nextLogLineToRead;

        public FrmApps()
        {
            InitializeComponent();
        }

        private void FrmApps_Load(object sender, EventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            g.Height = (int)r.GetValue("GridH", g.Height);
            Utils.StringToGridColumns((string)r.GetValue("GridCols", string.Empty), g);

            Utils.LoadWindowStateFromRegistry(this, REGKEY); //load window position

            LoadConfig();
                        
            LoadGrid();
            UpdateButtons();
        }

        private void FrmApps_FormClosed(object sender, FormClosedEventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            r.SetValue("GridH", g.Height);
            r.SetValue("GridCols", Utils.GridColumnsToString(g));

            Utils.SaveWindowStateToRegistry(this, REGKEY); //save window position

            Vars.FrmAppsObj = null;
        }

        public void LoadConfig()
        {
            edLog.Font = new Font(Vars.Config.Log.FontName, Vars.Config.Log.FontSize);
            edLog.ForeColor = Vars.Config.Log.TextColor;
            edLog.BackColor = Vars.Config.Log.BgColor;

            edLog.WordWrap = Vars.Config.Log.WordWrap;            
        }

        private void LoadGrid()
        {
            _gridBind = new();
            _gridBind.DataSource = Vars.AppList;

            _updatingGrid = true;
            g.DataSource = _gridBind;
            _updatingGrid = false;
        }

        private void ReloadGrid()
        {            
            //When ResetBindings is called, the event SelectionChanged is fired every row in the grid.
            //So we use this boolean control to avoid unnecessary event calls.

            _updatingGrid = true;
            try
            {
                _gridBind.ResetBindings(false);
            }
            finally
            {
                _updatingGrid = false;
            }
        }

        private DigaoApplication GetSelApp()
        {
            if (g.CurrentRow == null) return null;
            return g.CurrentRow.DataBoundItem as DigaoApplication;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (FrmAppEditor.Run(false, null))
            {
                ApplicationsStore.SaveApplications();
                ReloadGrid();

                g.CurrentCell = g.Rows[g.RowCount - 1].Cells[0]; //select added record
                RecordSelected(); //force selection (apparently changing CurrentCell fires SelectionChanged with old row)
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var app = GetSelApp();
            if (FrmAppEditor.Run(true, app))
            {
                ApplicationsStore.SaveApplications();
                ReloadGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var app = GetSelApp();
            if (Messages.Question("Do you confirm deleting selected application?"))
            {
                Vars.AppList.Remove(app);

                ApplicationsStore.SaveApplications();
                ReloadGrid();

                RecordSelected();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            edLog.Clear(); //clear control manually, because log object is not sinchronyzed when app already selected!
            _nextLogLineToRead = 0;

            var app = GetSelApp();
            app.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            var app = GetSelApp();
            app.Stop();
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            foreach (var item in Vars.AppList)
            {
                if (item.Running)
                {
                    item.Stop();
                }
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            var app = GetSelApp();
            app.Logs.Clear();
            app.LastLogIsError = false;

            ReloadGrid();
            RecordSelected();

            Vars.FrmMainObj.UpdateTrayIcon(); //if current log ends with an error, the tray icon may switch when there is no other app with error
        }

        private void g_SelectionChanged(object sender, EventArgs e)
        {
            if (_updatingGrid) return;

            RecordSelected();
        }

        private void RecordSelected()
        {           
            UpdateButtons();
            ReloadSelectedLog();            
        }

        public void ReloadSelectedLog()
        {
            _nextLogLineToRead = 0;

            edLog.Clear();
            var app = GetSelApp();
            if (app != null)
            {
                AddRemainingLog(app);
            }
        }

        private void UpdateButtons()
        {
            var app = GetSelApp();
            var selected = app != null;

            btnEdit.Enabled = selected;
            btnDelete.Enabled = selected && !app.Running;

            btnStart.Enabled = selected && !app.Running;
            btnStop.Enabled = selected && app.Running;

            btnClearLog.Enabled = selected && app.Logs.Any();

            btnStopAll.Enabled = Vars.AppList.Any(x => x.Running);
        }

        public void EventUpdated(DigaoApplication app)
        {
            ReloadGrid();

            if (app == GetSelApp())
            {
                UpdateButtons();
            }
        }

        private void timerMonitor_Tick(object sender, EventArgs e)
        {
            timerMonitor.Enabled = false;
            stMonitoring.Visible = true;
            Task.Run(Analyze);
        }

        private void Analyze()
        {
            foreach (var app in Vars.AppList)
            {
                if (app.Running)
                {
                    app.Analyze();
                }
            }

            if (Vars.FrmAppsObj != null)
            {
                try
                {
                    this.Invoke(new MethodInvoker(() =>
                    {
                        ReloadGrid();
                        UpdateButtons();

                        var app = GetSelApp();
                        if (app != null)
                        {
                            AddRemainingLog(app);
                        }

                        stMonitoring.Visible = false;
                        timerMonitor.Enabled = true;
                    }));
                }
                catch (Exception)
                {
                    if (Vars.FrmAppsObj != null) throw;
                }
            }
        }

        private void AddRemainingLog(DigaoApplication app)
        {
            if (_nextLogLineToRead > app.Logs.Count) throw new Exception("Log index control out of sync!");
            if (_nextLogLineToRead == app.Logs.Count) return; //everything already sync

            StringBuilder sb = new();
            for (int i = _nextLogLineToRead; i < app.Logs.Count; i++)
            {
                var log = app.Logs[i];
                var text = log.Text;
                if (Vars.Config.Log.ShowTimestamp) text = DateTime.Now.ToString(Vars.DATETIME_FMT) + " - " + text;
                sb.AppendLine(text);

                _nextLogLineToRead = i + 1;
            }

            var contents = sb.ToString();
            if (!edLog.Lines.Any())
            {
                var len = contents.Length;
                const int MAX = 1000000;
                if (len > MAX)
                {
                    contents = "[...]" + contents.Substring(len - MAX);
                }
            }

            var alreadyBottom = edLog.SelectionStart == edLog.TextLength;
            edLog.SuspendPainting();
            edLog.AppendText(contents);
            edLog.ResumePainting(!alreadyBottom);            
        }

    }
}
