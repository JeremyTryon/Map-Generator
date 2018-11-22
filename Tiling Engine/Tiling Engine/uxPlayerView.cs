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
    public partial class uxPlayerView : Form
    {
        private World _map = null;
        private FlowLayoutPanel _mapPanel;

        public uxPlayerView()
        {
            InitializeComponent();
        }

        private void uxPlayerView_Load(object sender, EventArgs e)
        {

        }

        public void SetMap(World m)
        {
            _map = m;
            int size = _map.ReturnSize();
            Size max = SystemInformation.MaxWindowTrackSize;

            this.Width = max.Width;
            this.Height = max.Width;

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
                    if (_map.ReturnVisiblity(i, j)){
                        Label temp = _map.ReturnKnownLabel(i, j);
                        _mapPanel.Controls.Add(temp);
                    }
                    else
                    {
                        Label temp = new Label();
                        temp.BackColor = System.Drawing.Color.DarkGray;
                        temp.BorderStyle = BorderStyle.FixedSingle;
                        temp.MaximumSize = new System.Drawing.Size(20, 20);
                        temp.Margin = new Padding(0, 0, 0, 0);
                        _mapPanel.Controls.Add(temp);
                    }
                    

                }
            }
        }
    }
}
