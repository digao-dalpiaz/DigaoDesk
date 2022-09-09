using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
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

        private BindingListView<DigaoApplication> _gridBind;
        private bool _updatingGrid;

        private int _nextLogLineToRead;

        public FrmApps()
        {
            InitializeComponent();

            LoadLang();
        }

        private void LoadLang()
        {
            this.Text = Vars.Lang.Apps_Title;
            btnAdd.Text = Vars.Lang.Apps_Add;
            btnEdit.Text = Vars.Lang.Apps_Edit;
            btnDelete.Text = Vars.Lang.Apps_Delete;
            btnFilter.Text = Vars.Lang.Apps_Filter;
            miFilterAll.Text = Vars.Lang.Apps_Filter_All;
            miFilterRunning.Text = Vars.Lang.Apps_Filter_Running;
            miFilterStopped.Text = Vars.Lang.Apps_Filter_Stopped;
            btnStart.Text = Vars.Lang.Apps_Start;
            btnStop.Text = Vars.Lang.Apps_Stop;
            btnStopAll.Text = Vars.Lang.Apps_StopAll;
            btnFindLog.Text = Vars.Lang.Apps_FindLog;
            btnClearLog.Text = Vars.Lang.Apps_ClearLog;

            colName.HeaderText = Vars.Lang.Apps_Col_Name;
            colStatus.HeaderText = Vars.Lang.Apps_Col_Status;
            colStartTime.HeaderText = Vars.Lang.Apps_Col_StartTime;
            colRunningTime.HeaderText = Vars.Lang.Apps_Col_RunningTime;
            colMemory.HeaderText = Vars.Lang.Apps_Col_Memory;
            colProcessor.HeaderText = Vars.Lang.Apps_Col_Processor;
            colProcCount.HeaderText = Vars.Lang.Apps_Col_ThreadCount;
            colLastLogTime.HeaderText = Vars.Lang.Apps_Col_LastLogTime;
            colLogStatistics.HeaderText = Vars.Lang.Apps_Col_LogStatistics;
            colLogHealth.HeaderText = Vars.Lang.Apps_Col_LogHealth;
            colTcpStatus.HeaderText = Vars.Lang.Apps_Col_TcpStatus;

            stFunInfo.Text = Vars.Lang.Apps_StatusBar_Info;
            stMonitoring.Text = Vars.Lang.Apps_StatusBar_Scanning;
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
            Theme.UseImmersiveDarkMode(Handle);
            Theme.setToolStrip(toolBar);
            Theme.setGrid(g);
            Theme.setSplitter(splitter);
            Theme.setConsole(edLog);
            Theme.setStatusStrip(statusBar);
        }

        private void LoadGrid()
        {
            _gridBind = new(Vars.AppList);            
            LoadFilter();

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
                _gridBind.Refresh();
            }
            finally
            {
                _updatingGrid = false;
            }
        }

        private DigaoApplication GetSelApp()
        {
            if (g.CurrentRow == null) return null;
            return (g.CurrentRow.DataBoundItem as ObjectView<DigaoApplication>).Object;
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
            if (Messages.Question(Vars.Lang.Apps_ConfirmDelete))
            {
                Vars.AppList.Remove(app);

                ApplicationsStore.SaveApplications();
                ReloadGrid();

                RecordSelected();
            }
        }

        private void LoadFilter()
        {
            if (miFilterAll.Checked)
            {
                _gridBind.RemoveFilter();
            }
            else
            if (miFilterRunning.Checked)
            {
                _gridBind.ApplyFilter(x => x.Running);
            }
            else
            if (miFilterStopped.Checked)
            {
                _gridBind.ApplyFilter(x => !x.Running);
            }
            else
                throw new Exception("Invalid object");            
        }

        private void ApplyFilter(object sender, EventArgs e)
        { 
            foreach (ToolStripMenuItem item in btnFilter.DropDownItems)
            {
                item.Checked = (sender == item);
            }

            LoadFilter();
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

        private void btnFindLog_Click(object sender, EventArgs e)
        {
            if (Vars.FrmFindObj == null)
            {
                Vars.FrmFindObj = new();
            }

            Vars.FrmFindObj.ShowDialog();
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

            var hasLog = selected && app.Logs.Any();
            btnFindLog.Enabled = hasLog;
            btnClearLog.Enabled = hasLog;

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
            List<Task> tasks = new();

            foreach (var app in Vars.AppList)
            {
                if (app.Running)
                {
                    var task = new Task(app.Analyze);
                    task.Start();
                    tasks.Add(task);
                }
            }

            Task.WaitAll(tasks.ToArray());

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

            if (_nextLogLineToRead == 0) //only when fill from beggining
            {
                while (app.Logs.Count > 5000) app.Logs.RemoveAt(0);
            }

            var alreadyBottom = edLog.SelectionStart == edLog.TextLength;

            edLog.SuspendPainting();
            try
            {
                for (int i = _nextLogLineToRead; i < app.Logs.Count; i++)
                {
                    var log = app.Logs[i];
                    if (Vars.Config.Log.ShowTimestamp)
                    {
                        edLog.SelectionStart = edLog.TextLength;
                        edLog.SelectionColor = Color.Gray;
                        edLog.SelectedText = log.Timestamp.ToString(Vars.DATETIME_FMT) + " - ";
                    }

                    edLog.SelectionStart = edLog.TextLength;

                    Color textColor;
                    switch (log.Type)
                    {
                        case DigaoApplication.LogType.INFO:
                            textColor = Vars.Config.Theme.ConsoleFore;
                            break;
                        case DigaoApplication.LogType.ERROR:
                            textColor = Color.Salmon;
                            break;
                        case DigaoApplication.LogType.DYN_ERROR:
                            textColor = Color.Crimson;
                            break;
                        case DigaoApplication.LogType.DYN_WARN:
                            textColor = Color.Orange;
                            break;
                        default:
                            throw new Exception("Log type invalid");
                    }
                    edLog.SelectionColor = textColor;
                    edLog.SelectedText = log.Text + Environment.NewLine;

                    _nextLogLineToRead = i + 1;
                }
            } finally
            {
                edLog.ResumePainting(!alreadyBottom);
            }
        }

        public bool FindInLog(bool fromCurrentPos)
        {
            RichTextBoxFinds opt = RichTextBoxFinds.None;

            if (Vars.FindMemoryObj.CaseSensitive) opt |= RichTextBoxFinds.MatchCase;
            if (Vars.FindMemoryObj.WholeWord) opt |= RichTextBoxFinds.WholeWord;

            int start = 0;
            if (fromCurrentPos) start = edLog.SelectionStart + edLog.SelectionLength;

            return edLog.Find(Vars.FindMemoryObj.Text, start, opt) > -1;
        }

        private void FindNext()
        {
            if (Vars.FindMemoryObj == null) return;

            if (!FindInLog(true))
            {
                Messages.Error(string.Format(Vars.Lang.Apps_FindNextNotFound, Vars.FindMemoryObj.Text));
            }
        }

        private void FrmApps_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3 && e.Modifiers == Keys.None)
            {
                FindNext();
            }
        }

    }
}
