using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmApps : Form
    {

        private const string REGKEY = Vars.APP_REGKEY + @"\Apps";

        private BindingListView<DigaoApplication> _gridBind;
        private bool _updatingGrid;

        private DigaoApplication.LogRecord _lastLogRecord;

        public FrmApps()
        {
            InitializeComponent();

            LoadLang();

            Utils.SetGridDoubleBuffer(g);
        }

        private void LoadLang()
        {
            this.Text = Vars.Lang.Apps_Title;
            btnAdd.Text = Vars.Lang.Apps_Add;
            btnEdit.Text = Vars.Lang.Apps_Edit;
            btnDelete.Text = Vars.Lang.Apps_Delete;
            btnDownloadDefs.Text = Vars.Lang.Apps_DownloadDefs;
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
            colLogLines.HeaderText = Vars.Lang.Apps_Col_LogLines;
            colLogSize.HeaderText = Vars.Lang.Apps_Col_LogSize;
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

        private DigaoApplication GetAppByRow(DataGridViewRow row)
        {
            return (row.DataBoundItem as ObjectView<DigaoApplication>).Object;
        }

        public DigaoApplication GetSelApp()
        {
            if (g.CurrentRow == null) return null;
            return GetAppByRow(g.CurrentRow);
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
            ClearLog();

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
            app.ClearLog();

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

        private void ClearLog()
        {
            edLog.Clear();
            _lastLogRecord = null;
        }

        public void ReloadSelectedLog()
        {
            ClearLog();

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
            ReloadGrid();
            UpdateButtons();

            var appSelected = GetSelApp();
            if (appSelected != null)
            {
                AddRemainingLog(appSelected);
            }

            if (Vars.Config.Apps.CalcResources)
            {
                foreach (var app in Vars.AppList)
                {
                    if (app.Running)
                    {
                        if (app.monitorTask == null || app.monitorTask.IsCompleted)
                        {
                            app.monitorTask = new(app.Analyze);
                            app.monitorTask.Start();
                        }
                    }
                }
            }
        }

        private void AddRemainingLog(DigaoApplication app)
        {
            if (!app.Logs.Any() || _lastLogRecord == app.Logs.Last()) return; //everything already sync

            var alreadyBottom = edLog.SelectionStart == edLog.TextLength;

            edLog.SuspendPainting();
            try
            {
                var nextIdx = app.Logs.IndexOf(_lastLogRecord) + 1;
                var lst = app.Logs.GetRange(nextIdx, app.Logs.Count - nextIdx);

                foreach (var log in lst)
                {
                    if (Vars.Config.Theme.ShowTimestamp)
                    {
                        edLog.SelectionStart = edLog.TextLength;
                        edLog.SelectionColor = Color.Gray;
                        edLog.SelectedText = log.Timestamp.ToString(Vars.DATETIME_FMT) + " - ";
                    }

                    edLog.SelectionStart = edLog.TextLength;
                    edLog.SelectionColor = LogTypeToColor(log.Type);
                    edLog.SelectedText = log.Text + Environment.NewLine;
                }

                _lastLogRecord = lst.Last();

                if (edLog.TextLength > Vars.Config.Apps.MaxLogSize)
                {
                    //clear bottom log when overloads max log size
                    edLog.SelectionStart = 0;
                    edLog.SelectionLength = edLog.TextLength - Vars.Config.Apps.MaxLogSize;
                    edLog.SelectedText = "[...]";
                }
            }
            finally
            {
                edLog.ResumePainting(!alreadyBottom);
            }

            app.PendingLog = false;
        }

        private Color LogTypeToColor(DigaoApplication.LogType type)
        {
            switch (type)
            {
                case DigaoApplication.LogType.INFO:
                    return Vars.Config.Theme.ConsoleFore;
                case DigaoApplication.LogType.ERROR:
                    return Color.Salmon;
                case DigaoApplication.LogType.DYN_ERROR:
                    return Color.Crimson;
                case DigaoApplication.LogType.DYN_WARN:
                    return Color.Orange;
                case DigaoApplication.LogType.STOP:
                    return Color.MediumPurple;
                default:
                    throw new Exception("Log type invalid");
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

        private void g_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var col = g.Columns[e.ColumnIndex];
            var app = GetAppByRow(g.Rows[e.RowIndex]);

            int? imageIndex = null;

            if (Utils.IsSameGridColumn(col, colStatus))
            {
                imageIndex = app.Running ? 0 : 1;
            }
            else if (Utils.IsSameGridColumn(col, colLogHealth))
            {
                if (app.LogHealth != null) imageIndex = app.LogHealth == "OK" ? 2 : 3;
            }
            else if (Utils.IsSameGridColumn(col, colTcpStatus))
            {
                if (app.TcpStatus != null) imageIndex = app.TcpStatus == "UP" ? 4 : 5;
            }
            else if (Utils.IsSameGridColumn(col, colLastLogTime))
            {
                imageIndex = app.PendingLog ? 6 : 7;
            }

            if (imageIndex.HasValue)
            {
                e.PaintBackground(e.ClipBounds, true);
                e.Graphics.DrawString(Convert.ToString(e.FormattedValue),
                    e.CellStyle.Font, new SolidBrush(e.State.HasFlag(DataGridViewElementStates.Selected) ? e.CellStyle.SelectionForeColor : e.CellStyle.ForeColor),
                    e.CellBounds.X + 20, e.CellBounds.Y + ((e.CellBounds.Height - e.CellStyle.Font.Height) / 2));
                Utils.DrawGridImage(images, e, imageIndex.Value);
                e.Handled = true;
            }
        }

        private void FrmApps_Activated(object sender, EventArgs e)
        {
            edLog.ScrollToCaret();
        }

        private void btnDownloadDefs_Click(object sender, EventArgs e)
        {
            DefinitionsDownload dd = new();
            if (dd.DoDownloadDialog())
            {
                ReloadGrid();
            }
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            List<FrmReorder.ReorderItem<DigaoApplication>> list = new();
            foreach (var app in Vars.AppList)
            {
                list.Add(new FrmReorder.ReorderItem<DigaoApplication>(app.Name, app));
            }

            List<DigaoApplication> resultList = new();
            if (FrmReorder.ReorderList(list, ref resultList))
            {
                Vars.AppList.Clear();
                Vars.AppList.AddRange(resultList);

                ReloadGrid();
            }
        }

    }
}
