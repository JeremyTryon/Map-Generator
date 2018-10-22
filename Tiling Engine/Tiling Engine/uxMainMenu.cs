using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiling_Engine
{
    public partial class uxMainMenu : Form
    {
        private uxEditor editor;
        private World _map;

        public uxMainMenu()
        {
            InitializeComponent();
            uxEditM.Enabled = false;
            uxViewM.Enabled = false;
        }

        private void uxNewM_Click(object sender, EventArgs e)
        {
            editor = new uxEditor();
            uxEditM.Enabled = true;
            uxViewM.Enabled = true;
        }

        private void uxLoadM_Click(object sender, EventArgs e)
        {
            //editor = file read in
            uxEditM.Enabled = true;
            uxViewM.Enabled = true;
        }

        private void uxEditM_Click(object sender, EventArgs e)
        {

        }

        private void uxViewM_Click(object sender, EventArgs e)
        {

        }

        private void uxSandQ_Click(object sender, EventArgs e)
        {

        }
    }
}
