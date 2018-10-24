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
    public partial class uxEditor : Form
    {
        private World _map;

        public uxEditor()
        {
            InitializeComponent();
            _map = new World();
        }

        public World ReturnMap()
        {
            return _map;
        }

        public void SetMap(World m)
        {
            _map = m;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uxGenerate_Click(object sender, EventArgs e)
        {
            _map.Generate();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uxBiomes_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                _map.SetMouseColor(Convert.ToInt16(button.Tag));

            }
        }

    }
}
