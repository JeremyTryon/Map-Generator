using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiling_Engine
{
    class Cell
    {
        private Label _label;
        private bool _visible;
        public enum Region{N,G,D,M,O,T};
        private Tuple<int, int> _coor;

        public Cell(int x, int y)
        {
            _coor = new Tuple<int, int>(x, y);
            _label = new Label();
        }

        public void ChangeColor(Region R)
        {
            if(R == Region.N)
            {
                _label.BackColor = System.Drawing.Color.DarkGray;
            }
            else if (R == Region.G)
            {
                _label.BackColor = System.Drawing.Color.Green;
            }
            else if (R == Region.D)
            {
                _label.BackColor = System.Drawing.Color.Green;
            }
            else if (R == Region.M)
            {
                _label.BackColor = System.Drawing.Color.LightGray;
            }
            else if (R == Region.O)
            {
                _label.BackColor = System.Drawing.Color.Blue;
            }
            else if (R == Region.T)
            {
                _label.BackColor = System.Drawing.Color.LightBlue;
            }
        }

        public bool IsVisible()
        {
            return _visible;
        }

        public void setVisible(bool b)
        {
            _visible = b;
        }
    }
}
