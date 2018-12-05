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
    public partial class uxViewer : Form
    {
        private World _map = null;
        private FlowLayoutPanel _mapPanel;
        private uxPlayerView _playerview;
        bool openPlayer;

        public uxViewer()
        {
            InitializeComponent();
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

            outerPanel.BackgroundImage = Properties.Resources.conifer_forest_inner;

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

        private void objectPlaces()
        {
            int buttonX = (this.Height + uxBack.Size.Width) + 55;
            int RBX = (this.Height + uxRBHide.Size.Width) + 20;

            //buttons
            uxBack.Location = new Point(buttonX, 33);
            uxPView.Location = new Point(buttonX, 106);

            //radiobuttons
            uxRBHide.Location = new Point(RBX, 185);
            uxRBShow.Location = new Point(RBX, 231);

            this.Width = buttonX + 200;
        }

        private void uxVis_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            if (button.Checked)
            {
                _map.SetMouseColor(Convert.ToInt16(button.Tag));

            }
        }

        private void uxBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (openPlayer)
            {
                _playerview.Close();
            }
        }

        private void uxPView_Click(object sender, EventArgs e)
        {
            _playerview = new uxPlayerView();
            _playerview.BackgroundImage = Properties.Resources.stone2;
            _playerview.SetMap(_map);
            openPlayer = true;
            _playerview.Show();
        }

        private void uxViewer_Load(object sender, EventArgs e)
        {
            uxRBHide.Checked = true;
            openPlayer = false;
        }

        public World ReturnMap()
        {
            return _map;
        }
    }
}
