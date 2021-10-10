using System;
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
                this.Text = "Edit Application";

                edName.Text = _app.Name;
                edCmd.Text = _app.Cmd;
                edArgs.Text = _app.Args;
                edDir.Text = _app.WorkDir;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            edName.Text = edName.Text.Trim();
            if (edName.Text == string.Empty)
            {
                Messages.Error("Specify an application name");
                edName.Select();
                return;
            }

            edCmd.Text = edCmd.Text.Trim();
            if (edCmd.Text == string.Empty)
            {
                Messages.Error("Specify an application file path");
                edCmd.Select();
                return;
            }
            if (!File.Exists(edCmd.Text)) {
                Messages.Error("File not found");
                edCmd.Select();
                return;
            }

            edArgs.Text = edArgs.Text.Trim();

            edDir.Text = edDir.Text.Trim();
            if (edDir.Text != string.Empty)
            {
                if (!Directory.Exists(edDir.Text))
                {
                    Messages.Error("Directory not found");
                    edDir.Select();
                    return;
                }
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

            DialogResult = DialogResult.OK;
        }

    }
}
