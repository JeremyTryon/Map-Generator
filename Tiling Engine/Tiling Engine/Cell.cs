using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiling_Engine
{
    public class Cell
    {
        private Label _label;
        private bool _visible;
        private Tuple<int, int> _coor;

        public Cell(int x, int y)
        {
            _coor = new Tuple<int, int>(x, y);
            _label = new Label();
            _visible = false;
        }

        public void ChangeColor(int color)
        {
            if(color == 0)
            {
                _label.BackColor = System.Drawing.Color.DarkGray;
            }
            else if (color == 1)
            {
                _label.BackColor = System.Drawing.Color.Green;
            }
            else if (color == 2)
            {
                _label.BackColor = System.Drawing.Color.Green;
            }
            else if (color == 3)
            {
                _label.BackColor = System.Drawing.Color.LightGray;
            }
            else if (color == 4)
            {
                _label.BackColor = System.Drawing.Color.Blue;
            }
            else if (color == 5)
            {
                _label.BackColor = System.Drawing.Color.White;
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
