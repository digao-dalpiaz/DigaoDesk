namespace DigaoDeskApp
{
    public partial class FrmConfigGitGroup : Form
    {

        public Config.CfgGitGroup Group;

        public FrmConfigGitGroup()
        {
            InitializeComponent();

            LoadLang();

            btnSelPath.Height = edPath.Height;
        }

        private void LoadLang()
        {
            lbIdent.Text = Vars.Lang.ConfigGitGroup_Ident;
            lbPath.Text = Vars.Lang.ConfigGitGroup_Path;
            boxAuthor.Text = Vars.Lang.ConfigGitGroup_BoxAuthor;
            lbAuthorName.Text = Vars.Lang.ConfigGitGroup_Author_Name;
            lbAuthorEmail.Text = Vars.Lang.ConfigGitGroup_Author_Email;
            boxCredentials.Text = Vars.Lang.ConfigGitGroup_BoxCredentials;
            lbCredUsername.Text = Vars.Lang.ConfigGitGroup_Credentials_Username;
            lbCredPassword.Text = Vars.Lang.ConfigGitGroup_Credentials_Password;

            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;
        }

        private void FrmConfigGitGroup_Shown(object sender, EventArgs e)
        {
            if (Group == null)
            {
                this.Text = Vars.Lang.ConfigGitGroup_TitleNew;
            }
            else
            {
                this.Text = Vars.Lang.ConfigGitGroup_TitleEdit;

                edIdent.Text = Group.Ident;
                edPath.Text = Group.Path;
                edAuthorName.Text = Group.AuthorName;
                edAuthorEmail.Text = Group.AuthorEmail;
                edCredUsername.Text = Group.CredUsername;
                edCredPassword.Text = Group.CredPassword;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            edIdent.Text = edIdent.Text.Trim();
            if (edIdent.Text == string.Empty)
            {
                Messages.Error(Vars.Lang.ConfigGitGroup_IdentRequired);
                edIdent.Select();
                return;
            }

            edPath.Text = edPath.Text.Trim();
            if (edPath.Text == string.Empty)
            {
                Messages.Error(Vars.Lang.ConfigGitGroup_PathRequired);
                edPath.Select();
                return;
            }

            if (!Directory.Exists(edPath.Text))
            {
                Messages.Error(Vars.Lang.ConfigGitGroup_PathNotFound);
                edPath.Select();
                return;
            }

            //

            if (Group == null)
            {
                Group = new();
                Group.InitUUID();
            }
            Group.Ident = edIdent.Text; //already trim
            Group.Path = edPath.Text; //already trim
            Group.AuthorName = edAuthorName.Text.Trim();
            Group.AuthorEmail = edAuthorEmail.Text.Trim();
            Group.CredUsername = edCredUsername.Text.Trim();
            Group.CredPassword = edCredPassword.Text; //NO trim!!!

            DialogResult = DialogResult.OK;
        }

        private void btnSelPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new();

            dlg.SelectedPath = edPath.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edPath.Text = dlg.SelectedPath;
            }
        }

    }
}
