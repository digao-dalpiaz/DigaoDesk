using LibGit2Sharp;
using System;
using System.Linq;
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
                var commit = _tag.Target as Commit;
                return $"{_tag.FriendlyName} ({commit.Author.When.ToLocalTime().ToString(Vars.DATETIME_FMT)} - {commit.Id.Sha} - {commit.Author.Name})";
            }
        }

        private static bool IsTagCommit(Tag tag)
        {
            return tag.Target != null && tag.Target is Commit;
        }        

        public FrmBranchCreate(Repository repository)
        {
            InitializeComponent();

            LoadLang();

            _repoCtrl = repository;
        }

        private void FrmBranchCreate_Load(object sender, EventArgs e)
        {
            BuildPrefixMenu();

            edCurrentBranch.Text = _repoCtrl.Head.FriendlyName;
            ckBasedOnOption_Click(null, null);
        }

        public void LoadLang()
        {
            this.Text = Vars.Lang.BranchCreate_Title;
            btnPrefix.Text = Vars.Lang.BranchCreate_InsertPrefix;
            lbBranchName.Text = Vars.Lang.BranchCreate_BranchName;
            boxBasedOn.Text = Vars.Lang.BranchCreate_BasedOn;
            ckCurrentBranch.Text = Vars.Lang.BranchCreate_OptCurrentBranch;
            ckTag.Text = Vars.Lang.BranchCreate_OptSpecificTag;
            ckSwitch.Text = Vars.Lang.BranchCreate_AutoSwitch;
            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;
        }

        private void BuildPrefixMenu()
        {
            var prefixesTextList = Vars.Config.Repos.GitNewBranchPrefixList;
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

            edName.Select();
            edName.SelectionStart = edName.TextLength;
        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {
            if (menuPrefix.Items.Count == 0)
            {
                Messages.Error(Vars.Lang.BranchCreate_NoPrefixConfigured);
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

            foreach (var tag in _repoCtrl.Tags.Where(x => IsTagCommit(x)).OrderByDescending(x => (x.Target as Commit).Author.When.ToLocalTime()))
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
                Messages.Error(Vars.Lang.BranchCreate_BranchNameRequired);
                edName.Select();
                return;
            }

            if (ckTag.Checked)
            {
                if (edTag.SelectedItem == null)
                {
                    Messages.Error(Vars.Lang.BranchCreate_TagRequired);
                    edTag.Select();
                    return;
                }
            }

            //

            NewBranchParams p = new();
            p.Name = edName.Text;
            p.Tag = (ckTag.Checked) ? (edTag.SelectedItem as TagView).Tag : null;
            p.Switch = ckSwitch.Checked;

            ResultParams = p;

            DialogResult = DialogResult.OK;
        }
        
    }
}
