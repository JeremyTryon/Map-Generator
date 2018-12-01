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
        FlowLayoutPanel _outerPanel;

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
            this.Controls.Remove(_outerPanel);
            _map = m;
            int size = _map.ReturnSize();
            Size max = SystemInformation.MaxWindowTrackSize;

            this.Width = max.Width;
            this.Height = max.Height;

            //flow layout panel
            _mapPanel = new FlowLayoutPanel();
            _outerPanel = new FlowLayoutPanel();

            _outerPanel.Size = new System.Drawing.Size((this.Height), (this.Height));
            _mapPanel.Size = new System.Drawing.Size((20 * size), (20 * size));

            _outerPanel.BackgroundImage = Properties.Resources.conifer_forest_inner;

            _outerPanel.VerticalScroll.Enabled = true;
            _outerPanel.HorizontalScroll.Enabled = true;

            _outerPanel.AutoScroll = true;
            _outerPanel.Dock = System.Windows.Forms.DockStyle.None;
            _outerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;



            this.Controls.Add(_outerPanel);
            _outerPanel.Controls.Add(_mapPanel);

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
            _outerPanel = new FlowLayoutPanel();

            _outerPanel.Size = new System.Drawing.Size((this.Height), (this.Height));
            _mapPanel.Size = new System.Drawing.Size((20 * size), (20 * size));

            _outerPanel.BackgroundImage = Properties.Resources.conifer_forest_inner;

            _outerPanel.VerticalScroll.Enabled = true;
            _outerPanel.HorizontalScroll.Enabled = true;

            _outerPanel.AutoScroll = true;
            _outerPanel.Dock = System.Windows.Forms.DockStyle.None;
            _outerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.Controls.Add(_outerPanel);
            _outerPanel.Controls.Add(_mapPanel);

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



        public void ClearMap(int size)
        {
            this.Controls.Remove(_outerPanel);
            _map = new World(size);
            Size max = SystemInformation.MaxWindowTrackSize;

            this.Width = max.Width;
            this.Height = max.Height;

            //flow layout panel
            _mapPanel = new FlowLayoutPanel();
            _outerPanel = new FlowLayoutPanel();

            _outerPanel.Size = new System.Drawing.Size((this.Height), (this.Height));
            _mapPanel.Size = new System.Drawing.Size((20 * size), (20 * size));

            _outerPanel.BackgroundImage = Properties.Resources.conifer_forest_inner;

            _outerPanel.VerticalScroll.Enabled = true;
            _outerPanel.HorizontalScroll.Enabled = true;

            _outerPanel.AutoScroll = true;
            _outerPanel.Dock = System.Windows.Forms.DockStyle.None;
            _outerPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.Controls.Add(_outerPanel);
            _outerPanel.Controls.Add(_mapPanel);

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

        private void uxClear_Click(object sender, EventArgs e)
        {
            int size = _map.ReturnSize();
            ClearMap(size);  
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
            int buttonX = (this.Height + uxBack.Size.Width);
            int RBX = (this.Height + uxRBlank.Size.Width) + 55;

            //buttons
            uxBack.Location = new Point(buttonX, 519);
            uxClear.Location = new Point(buttonX, 453);
            uxGenerate.Location = new Point(buttonX, 394);

            //uxClear.Visible = false;

            //radiobuttons
            uxRBlank.Location = new Point(RBX, 24);
            uxRGrass.Location = new Point(RBX, 51);
            uxRDesert.Location = new Point(RBX, 78);
            uxRMountains.Location = new Point(RBX, 105);
            uxROcean.Location = new Point(RBX, 132);
            uxRTundra.Location = new Point(RBX, 160);
            uxRCity.Location = new Point(RBX, 187);

            this.Width = buttonX + 200;
        }
    }
}
