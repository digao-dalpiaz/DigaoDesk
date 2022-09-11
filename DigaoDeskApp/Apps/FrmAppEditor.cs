using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmAppEditor : Form
    {

        private bool _edit;
        private DigaoApplication _app;

        public FrmAppEditor()
        {
            InitializeComponent();

            LoadLang();

            btnSelCmd.Height = edCmd.Height;
            btnSelDir.Height = edDir.Height;

            edTcpPort.Maximum = ushort.MaxValue;
        }

        private void LoadLang()
        {
            this.Text = Vars.Lang.AppEditor_Title_New;
            lbName.Text = Vars.Lang.AppEditor_AppName;
            lbCmd.Text = Vars.Lang.AppEditor_CmdLine;
            lbArgs.Text = Vars.Lang.AppEditor_Arguments;
            lbDir.Text = Vars.Lang.AppEditor_Directory;
            lbEnv.Text = Vars.Lang.AppEditor_EnvVars;
            lbEnvInfo.Text = Vars.Lang.AppEditor_EnvVarsInfo;
            lbTcpPort.Text = Vars.Lang.AppEditor_TcpPort;
            btnOK.Text = Vars.Lang.BtnOK;
            btnCancel.Text = Vars.Lang.BtnCancel;
        }

        public static bool Run(bool edit, DigaoApplication app)
        {
            FrmAppEditor f = new();
            f._edit = edit;
            f._app = app;
            return f.ShowDialog() == DialogResult.OK;
        }

        private void FrmAppEditor_Load(object sender, EventArgs e)
        {
            if (_edit)
            {
                this.Text = this.Text = Vars.Lang.AppEditor_Title_Edit;

                edName.Text = _app.Name;
                edCmd.Text = _app.Cmd;
                edArgs.Text = _app.Args;
                edDir.Text = _app.WorkDir;
                edEnv.Text = EnvVariablesParser.DictionaryToString(_app.EnvVars);
                if (_app.TcpPort.HasValue) edTcpPort.Value = _app.TcpPort.Value;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            edName.Text = edName.Text.Trim();
            if (edName.Text == string.Empty)
            {
                Messages.Error(Vars.Lang.AppEditor_AppNameRequired);
                edName.Select();
                return;
            }

            edCmd.Text = edCmd.Text.Trim();
            if (edCmd.Text == string.Empty)
            {
                Messages.Error(Vars.Lang.AppEditor_CmdLineRequired);
                edCmd.Select();
                return;
            }

            edArgs.Text = edArgs.Text.Trim();

            edDir.Text = edDir.Text.Trim();
            if (edDir.Text != string.Empty)
            {
                if (!Directory.Exists(edDir.Text))
                {
                    Messages.Error(Vars.Lang.AppEditor_DirectoryNotFound);
                    edDir.Select();
                    return;
                }
            }

            Dictionary<string, string> dic;
            try
            {
                dic = EnvVariablesParser.StringToDictionary(edEnv.Text); 
            }
            catch (Messages.MessageException msgEx)
            {
                Messages.Error(msgEx.Message);
                edEnv.Select();
                return;
            }

            //

            if (!_edit)
            {
                _app = new();
                Vars.AppList.Add(_app);
            }
            _app.Name = edName.Text;
            _app.Cmd = edCmd.Text;
            _app.Args = edArgs.Text;
            _app.WorkDir = edDir.Text;
            _app.EnvVars = dic;
            _app.TcpPort = edTcpPort.Text != "" && edTcpPort.Value > 0 ? (ushort)edTcpPort.Value : null;

            DialogResult = DialogResult.OK;
        }

        private void btnSelCmd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new();

            dlg.FileName = edCmd.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edCmd.Text = dlg.FileName;
            }
        }

        private void btnSelDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new();

            dlg.SelectedPath = edDir.Text;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                edDir.Text = dlg.SelectedPath;
            }
        }

    }
}
