using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigaoDeskApp
{
    public partial class FrmRepos : Form
    {

        private const string REGKEY = Vars.APP_REGKEY + @"\Repos";

        public FrmRepos()
        {
            InitializeComponent();
        }

        private void FrmRepos_Load(object sender, EventArgs e)
        {
            Utils.LoadWindowStateFromRegistry(this, REGKEY); //load window position
        }

        private void FrmRepos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Utils.SaveWindowStateToRegistry(this, REGKEY); //save window position

            Vars.FrmReposObj = null;
        }
        
    }
}
