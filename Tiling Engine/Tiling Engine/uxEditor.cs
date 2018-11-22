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
        private World _map = null;
        private FlowLayoutPanel _mapPanel;

        public uxEditor()
        {
            InitializeComponent();
        }

        public World ReturnMap()
        {
            return _map;
        }

        public void SetMap(World m)
        {
            _map = m;
            int size = _map.ReturnSize();
            Size max = SystemInformation.MaxWindowTrackSize;

            this.Width = max.Width;
            this.Height = max.Height;

            //flow layout panel
            _mapPanel = new FlowLayoutPanel();
            FlowLayoutPanel outerPanel = new FlowLayoutPanel();

            outerPanel.Size = new System.Drawing.Size((this.Height), (this.Height));
            _mapPanel.Size = new System.Drawing.Size((20 * size), (20 * size));

            outerPanel.VerticalScroll.Enabled = true;
            outerPanel.HorizontalScroll.Enabled = true;

            outerPanel.AutoScroll = true;
            outerPanel.Dock = System.Windows.Forms.DockStyle.None;
            outerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;



            this.Controls.Add(outerPanel);
            outerPanel.Controls.Add(_mapPanel);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Label temp = _map.ReturnKnownLabel(i, j);
                    _mapPanel.Controls.Add(temp);
                    temp.Click += (s, e) =>
                    {
                        Tuple<int, int> coor = (Tuple<int, int>)temp.Tag;
                        _map.CellClick(coor.Item1, coor.Item2);    
                    };

                }
            }
            objectPlaces();
        }

        public void MakeNew()
        {
            _map = new World();
            int size = _map.ReturnSize();
            Size max = SystemInformation.MaxWindowTrackSize;

            this.Width = max.Width;
            this.Height = max.Height;

            //flow layout panel
            _mapPanel = new FlowLayoutPanel();
            FlowLayoutPanel outerPanel = new FlowLayoutPanel();

            outerPanel.Size = new System.Drawing.Size((this.Height), (this.Height));
            _mapPanel.Size = new System.Drawing.Size((20 * size), (20 * size));

            outerPanel.VerticalScroll.Enabled = true;
            outerPanel.HorizontalScroll.Enabled = true;

            outerPanel.AutoScroll = true;
            outerPanel.Dock = System.Windows.Forms.DockStyle.None;
            outerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;



            this.Controls.Add(outerPanel);
            outerPanel.Controls.Add(_mapPanel);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Label temp = _map.ReturnLabel(i, j);
                    _mapPanel.Controls.Add(temp);
                    temp.Click += (s, e) =>
                    {
                        Tuple<int, int> coor = (Tuple<int, int>)temp.Tag;
                        _map.CellClick(coor.Item1, coor.Item2);
                    };
                }
            }
            objectPlaces();
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

        private void objectPlaces()
        {
            int buttonX = (this.Size.Width - uxBack.Size.Width) - 10;
            int RBX = (this.Size.Width - uxRBlank.Size.Width) - 55;

            //buttons
            uxBack.Location = new Point(buttonX, 426);
            uxGenerate.Location = new Point(buttonX, 477);

            //radiobuttons
            uxRBlank.Location = new Point(RBX, 24);
            uxRGrass.Location = new Point(RBX, 51);
            uxRDesert.Location = new Point(RBX, 78);
            uxRMountains.Location = new Point(RBX, 105);
            uxROcean.Location = new Point(RBX, 132);
            uxRTundra.Location = new Point(RBX, 160);
            uxRCity.Location = new Point(RBX, 187);
        }
    }
}
