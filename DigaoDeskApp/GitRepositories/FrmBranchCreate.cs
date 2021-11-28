using LibGit2Sharp;
using System;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmBranchCreate : Form
    {

        private bool _tagsLoaded = false;
        private Repository _repoCtrl;
        public NewBranchParams ResultParams;

        public class NewBranchParams
        {
            public string Name;
            public Tag Tag;
            public bool Switch;
        }

        public class TagView
        {
            Tag _tag;

            public TagView(Tag tag)
            {
                _tag = tag;
            }

            public Tag Tag
            {
                get
                {
                    return _tag;
                }
            }

            public override string ToString()
            {
                var info = _tag.FriendlyName;
                if (IsTagCommit(_tag))
                {
                    var commit = _tag.Target as Commit;
                    info += $" ({commit.Committer.Name} - {commit.Committer.When})";
                }
                return info;
            }
        }

        private static bool IsTagCommit(Tag tag)
        {
            return tag.Target != null && tag.Target is Commit;
        }        

        public FrmBranchCreate(Repository repository)
        {
            InitializeComponent();

            _repoCtrl = repository;
        }

        private void FrmBranchCreate_Load(object sender, EventArgs e)
        {
            BuildPrefixMenu();

            edCurrentBranch.Text = _repoCtrl.Head.FriendlyName;
            ckBasedOnOption_Click(null, null);
        }

        private void BuildPrefixMenu()
        {
            var prefixesTextList = Vars.Config.GitNewBranchPrefixList;
            if (prefixesTextList == null) return;

            var list = prefixesTextList.Split(Environment.NewLine);

            foreach (var item in list)
            {
                var text = item.Trim();
                if (text == string.Empty) continue;

                if (!text.EndsWith("/")) text += "/";
                menuPrefix.Items.Add(text, null, OnPrefixClick);
            }
        }

        private void OnPrefixClick(object sender, EventArgs e)
        {
            var i = edName.Text.LastIndexOf("/");
            if (i != -1)
            {
                edName.Text = edName.Text.Substring(i + 1);
            }

            var prefix = (sender as ToolStripItem).Text;
            edName.Text =  prefix + edName.Text;
        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {
            if (menuPrefix.Items.Count == 0)
            {
                Messages.Error("There are no prefixes configured. Go to Settings screen to set prefixes.");
                return;
            }

            menuPrefix.Show(btnPrefix, 0, btnPrefix.Height);
        }

        private void ckBasedOnOption_Click(object sender, EventArgs e)
        {
            edCurrentBranch.Enabled = ckCurrentBranch.Checked;
            edTag.Enabled = ckTag.Checked;

            if (ckTag.Checked) LoadTags();
        }

        private void LoadTags()
        {
            if (_tagsLoaded) return;

            foreach (var tag in _repoCtrl.Tags)
            {
                edTag.Items.Add(new TagView(tag));
            }

            _tagsLoaded = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            edName.Text = edName.Text.Trim();
            if (edName.Text == string.Empty)
            {
                Messages.Error("Please, specify the branch name");
                edName.Select();
                return;
            }

            Tag tag = null;
            if (ckTag.Checked)
            {
                if (edTag.SelectedItem == null)
                {
                    Messages.Error("Please, specify a tag");
                    edTag.Select();
                    return;
                }

                tag = (edTag.SelectedItem as TagView).Tag;
                if (!IsTagCommit(tag))
                {
                    Messages.Error("You can't use this tag becaus it does not target to a commit!");
                    edTag.Select();
                    return;
                }
            }

            //

            NewBranchParams p = new();
            p.Name = edName.Text;
            p.Tag = tag;
            p.Switch = ckSwitch.Checked;

            ResultParams = p;

            DialogResult = DialogResult.OK;
        }
        
    }
}
