using LibGit2Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmCherryPick : Form
    {

        private Repository _repository;
        private int _lineHeight;
        public Commit ResultCommit;

        public FrmCherryPick(Repository repository)
        {
            InitializeComponent();

            _repository = repository;
        }

        private void FrmCherryPick_Load(object sender, EventArgs e)
        {
            _lineHeight = TextRenderer.MeasureText("A", lstCommits.Font).Height;
            lstCommits.ItemHeight = (_lineHeight * 2) + 3;

            FillBranches();
            FillList();
        }

        private void FillBranches()
        {
            foreach (var item in _repository.Branches.Where(x => x.IsRemote))
            {
                edBranch.Items.Add(item.FriendlyName);
            }
        }

        private void FillList()
        {
            lstCommits.BeginUpdate();
            try
            {
                lstCommits.Items.Clear();

                if (edBranch.SelectedItem == null) return;
                var branch = _repository.Branches[edBranch.SelectedItem.ToString()];
                if (branch == null) return;

                foreach (var item in branch.Commits.Where(x => {
                    if (edStartDate.Checked) if (!(x.Author.When.ToLocalTime().Date >= edStartDate.Value.Date)) return false;
                    if (edEndDate.Checked) if (!(x.Author.When.ToLocalTime().Date <= edEndDate.Value.Date)) return false;
                    if (edSearch.Text != string.Empty) if (!(x.Id.Sha.StartsWith(edSearch.Text, StringComparison.InvariantCultureIgnoreCase) || x.MessageShort.Contains(edSearch.Text, StringComparison.InvariantCultureIgnoreCase))) return false;
                    return true;
                }))
                {
                    lstCommits.Items.Add(item);
                }
            }
            finally
            {
                lstCommits.EndUpdate();
            }
        }

        private void lstCommits_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;

            e.DrawBackground();
            if (e.Index % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.Beige, e.Bounds);
            }
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.Gold, e.Bounds);
            }

            var item = lstCommits.Items[e.Index] as Commit;

            TextRenderer.DrawText(e.Graphics, item.Id.ToString(), lstCommits.Font, new Point(e.Bounds.X + 2, e.Bounds.Y + 1), Color.Green);
            TextRenderer.DrawText(e.Graphics, item.MessageShort, lstCommits.Font, new Point(e.Bounds.X + 2, e.Bounds.Y + 1 + _lineHeight), Color.Black);

            string info = $"(Author: {item.Author.Name} - Date: {item.Author.When.ToLocalTime().ToString(Vars.DATETIME_FMT)})";
            var w = TextRenderer.MeasureText(info, lstCommits.Font).Width;
            TextRenderer.DrawText(e.Graphics, info, lstCommits.Font, new Point(lstCommits.Width - w - 24, e.Bounds.Y + 1), Color.Gray);

            e.DrawFocusRectangle();
        }

        private void edBranch_TextChanged(object sender, EventArgs e)
        {
            FillList();
        }

        private void edSearch_TextChanged(object sender, EventArgs e)
        {
            FillList();
        }

        private void edDates_ValueChanged(object sender, EventArgs e)
        {
            FillList();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstCommits.SelectedItem == null)
            {
                Messages.Error("Please, select a commit.");
                return;
            }

            //

            ResultCommit = (lstCommits.SelectedItem as Commit);

            DialogResult = DialogResult.OK;
        }
        
    }
}
