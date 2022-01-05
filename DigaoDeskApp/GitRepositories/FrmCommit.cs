using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmCommit : Form
    {

        private const string REGKEY = Vars.APP_REGKEY + @"\Commit";

        private Repository _repository;
        private CommitService _service;

        private int _itemTextHeight;

        public string ReturnMessage;

        public FrmCommit(DigaoRepository repository)
        {
            InitializeComponent();

            edMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCommit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCommitAndPush.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            this._repository = repository._repoCtrl;

            lbRepository.Text = repository.Name;
            lbBranch.Text = repository._repoCtrl.Head.FriendlyName;

            this._service = new(repository._repoCtrl);

            InitListsDrawItem();
        }

        private void FrmCommit_Load(object sender, EventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            lstStaged.Height = (int)r.GetValue("ListH", lstStaged.Height);

            Utils.LoadWindowStateFromRegistry(this, REGKEY); //load window position                      

            AutoFillMessageHashtag();

            LoadLists();
        }

        private void FrmCommit_FormClosed(object sender, FormClosedEventArgs e)
        {
            var r = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(REGKEY);
            r.SetValue("ListH", lstStaged.Height);

            Utils.SaveWindowStateToRegistry(this, REGKEY); //save window position
        }

        private void AutoFillMessageHashtag()
        {
            ParseCommitMessage p = new(_repository);
            edMessage.Text = p.GetMessage();
        }

        private void InitListsDrawItem()
        {
            _itemTextHeight = Font.Height;
            int h = Math.Max(_itemTextHeight, images.ImageSize.Height) + 5;
            lstStaged.SetItemHeight(h);
            lstDif.SetItemHeight(h);

            lstStaged.CustomDrawItem += OnDrawItem;
            lstDif.CustomDrawItem += OnDrawItem;
        }

        private void OnDrawItem(object sender, DrawItemEventArgs e)
        {
            var control = sender as CheckedListBoxEx;
            var item = control.Items[e.Index] as CommitItemView;

            List<int> lstImages = new();
            if (item.ContainsFlagNew) lstImages.Add(0);
            if (item.ContainsFlagModified) lstImages.Add(1);
            if (item.ContainsFlagDeleted) lstImages.Add(2);
            if (item.ContainsFlagRenamed) lstImages.Add(3);

            int lastX = e.Bounds.X + control.BoxAreaWidth + 4;
            foreach (var idx in lstImages)
            {
                images.Draw(e.Graphics, lastX, e.Bounds.Y + ((e.Bounds.Height - images.ImageSize.Height)/2), idx);
                lastX += images.ImageSize.Width + 4;
            }

            e.Graphics.DrawString(item.DisplayText, control.Font, Brushes.Black, lastX, e.Bounds.Y + ((e.Bounds.Height - _itemTextHeight)/2));
        }

        private void LoadLists()
        {
            _service.LoadLists(lstStaged, lstDif, lstOther);

            lbCountStaged.Text = lstStaged.Items.Count.ToString();
            lbCountDif.Text = lstDif.Items.Count.ToString();

            lstOther.Visible = lstOther.Items.Count > 0;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLists();
        }

        private void btnStage_Click(object sender, EventArgs e)
        {
            if (lstDif.CheckedItems.Count == 0) return;

            foreach (CommitItemView item in lstDif.CheckedItems)
            {
                Commands.Stage(_repository, item.Path);
            }

            LoadLists();
        }

        private void btnUnstage_Click(object sender, EventArgs e)
        {
            if (lstStaged.CheckedItems.Count == 0) return;

            foreach (CommitItemView item in lstStaged.CheckedItems)
            {
                Commands.Unstage(_repository, item.Path);
            }

            LoadLists();
        }

        private void btnGroupSelection_Click(object sender, EventArgs e)
        {
            if (sender == btnAllStaged) { GroupSelection(lstStaged, true); return; }
            if (sender == btnNoneStaged) { GroupSelection(lstStaged, false); return; }
            if (sender == btnInvertStaged) { GroupSelection(lstStaged, null); return; }

            if (sender == btnAllDif) { GroupSelection(lstDif, true); return; }
            if (sender == btnNoneDif) { GroupSelection(lstDif, false); return; }
            if (sender == btnInvertDif) { GroupSelection(lstDif, null); return; }

            throw new Exception("Invalid control");
        }

        private void GroupSelection(CheckedListBoxEx lst, bool? op)
        {
            for (int i = 0; i < lst.Items.Count; i++)
            {
                bool v = (op == null) ? !lst.GetItemChecked(i) : op.Value;
                lst.SurroundAllowingCheck(() => lst.SetItemChecked(i, v));                
            }
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (lstStaged.Items.Count == 0)
            {
                Messages.Error("There is no file in stage area");
                return;
            }

            edMessage.Text = edMessage.Text.Trim();
            if (edMessage.Text == string.Empty)
            {
                Messages.Error("Type a message to this commit");
                edMessage.Select();
                return;
            }

            //

            if (!Messages.Question("Confirm commit?")) return;

            ReturnMessage = edMessage.Text;

            DialogResult = (sender == btnCommitAndPush) ? DialogResult.Continue : DialogResult.OK;
        }

        private void lstItem_Click(object sender, EventArgs e)
        {
            if (!(sender == lstStaged || sender == lstDif)) throw new Exception("Invalid control");

            var lst = sender as CheckedListBoxEx;
            var item = lst.SelectedItem as CommitItemView;
            if (item == null) return;

            //ensure click in item area
            Point loc = lst.PointToClient(Cursor.Position);
            Rectangle rec = lst.GetItemRectangle(lst.SelectedIndex);
            if (!rec.Contains(loc)) return;

            Messages.SurroundMessageException(() =>
            {
                _service.CompareItem(item, lst == lstStaged);
            });
        }

        private void btnUndoDif_Click(object sender, EventArgs e)
        {
            if (lstDif.CheckedItems.Count == 0) return;
            if (!Messages.Question("Confirm undo checked files?")) return;

            Messages.SurroundMessageException(() =>
            {
                foreach (CommitItemView item in lstDif.CheckedItems)
                {
                    _service.UndoFileByItem(item);
                }
            });

            LoadLists(); //reload even if error occurred
        }

    }
}
