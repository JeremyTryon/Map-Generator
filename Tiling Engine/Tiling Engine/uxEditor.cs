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
        private FlowLayoutPanel _mapPanel;

        public uxEditor()
        {
            InitializeComponent();
            
            //new map
            _map = new World();
            int size = 20; //_map.ReturnSize();

            //flow layout panel
            _mapPanel = new FlowLayoutPanel();
            _mapPanel.Size = new System.Drawing.Size((20 * size), (20 * size));

            this.Controls.Add(_mapPanel);

            for (int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    Label temp = _map.ReturnLabel(i, j);
                    _mapPanel.Controls.Add(temp);
                    temp.Click += (s, e) =>
                    {
                        Tuple<int, int> coor = (Tuple<int,int>)temp.Tag;
                        _map.CellClick(coor.Item1, coor.Item2);

                    };
                    
                }
            }
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
            uxRBlank.Checked = true;
        }

        private void uxGenerate_Click(object sender, EventArgs e)
        {
            _map.Generate();
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            _map.CreateCity(1, 1);
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
