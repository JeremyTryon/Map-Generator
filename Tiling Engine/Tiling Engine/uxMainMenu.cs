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
        //private uxViewer viewer;
        private World _map;

        public uxMainMenu()
        {
            InitializeComponent();
            uxEditM.Enabled = false;
            uxViewM.Enabled = false;
            _map = new World();
        }

        private void uxNewM_Click(object sender, EventArgs e)
        {
            editor = new uxEditor();
            this.Hide();
            editor.ShowDialog();
            _map = editor.ReturnMap();
            this.Show();
            uxEditM.Enabled = true;
            uxViewM.Enabled = true;
        }

        private void uxLoadM_Click(object sender, EventArgs e)
        {
            //_map = file read in

            uxEditM.Enabled = true;
            uxViewM.Enabled = true;
        }

        private void uxEditM_Click(object sender, EventArgs e)
        {
            this.Hide();
            editor.SetMap(_map);
            editor.ShowDialog();
            _map = editor.ReturnMap();
            this.Show();
        }

        private void uxViewM_Click(object sender, EventArgs e)
        {
            //viewer.SetMap(_map);
        }

        private void uxSandQ_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
