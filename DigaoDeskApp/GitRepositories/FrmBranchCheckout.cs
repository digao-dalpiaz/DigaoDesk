using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmBranchCheckout : Form
    {

        private List<BranchView> _lst = new();        

        public FrmBranchCheckout()
        {
            InitializeComponent();
        }

        private void FrmBranchCheckout_Load(object sender, EventArgs e)
        {
            l.ItemHeight = TextRenderer.MeasureText("A", l.Font).Height + 3;

            edSearch_TextChanged(null, null);
        }

        private void edSearch_TextChanged(object sender, EventArgs e)
        {
            l.Items.Clear();
            l.Items.AddRange(_lst.Where(x => edSearch.Text == string.Empty || x.BranchData.FriendlyName.Contains(edSearch.Text, StringComparison.InvariantCultureIgnoreCase)).ToArray());
            if (l.Items.Count > 0)
            {
                l.SelectedIndex = 0;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (l.SelectedItem == null)
            {
                Messages.Error("Please, select a branch!");
                l.Select();
                return;
            }

            DialogResult = DialogResult.OK;
        }

        public void AddBranches(IEnumerable<Branch> lst)
        {
            foreach (var item in lst.OrderByDescending(x => x.Tip.Author.When))
            {
                _lst.Add(new BranchView(item));
            }
        }

        public Branch GetSelected()
        {
            return (l.SelectedItem as BranchView).BranchData;
        }

        private void l_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1) return;

            e.DrawBackground();
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(Brushes.Gold, e.Bounds);
            }

            var item = l.Items[e.Index] as BranchView;

            TextRenderer.DrawText(e.Graphics, item.BranchData.FriendlyName, l.Font, new Point(e.Bounds.X + 2, e.Bounds.Y + 1), Color.Black);

            string info = $"(Author: {item.BranchData.Tip.Author.Name} - Date: {item.BranchData.Tip.Author.When.ToString(Vars.DATETIME_FMT)})";
            var w = TextRenderer.MeasureText(info, l.Font).Width;
            TextRenderer.DrawText(e.Graphics,info, l.Font, new Point(l.Width-w-24, e.Bounds.Y + 1), Color.Gray);

            e.DrawFocusRectangle();
        }

    }
}
