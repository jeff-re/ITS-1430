using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
        }

        private void ExitToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            Close ();
        }

        private void AboutToolStripMenuItem_Click ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);

        }
    }
}
