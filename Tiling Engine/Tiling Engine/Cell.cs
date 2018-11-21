using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Tiling_Engine
{
    [Serializable]
    public class Cell
    {
        [NonSerialized]
        private Label _label;

        private bool _visible;
        private Tuple<int, int> _coor;
        private int _color = 0;

        public Cell(int x, int y)
        {
            _coor = new Tuple<int, int>(x, y);

            _label = new Label();
            _label.BackColor = System.Drawing.Color.LightGray;
            _label.BorderStyle = BorderStyle.FixedSingle;
            _label.MaximumSize = new System.Drawing.Size(20, 20);
            _label.Margin = new Padding(0, 0, 0, 0);
            _label.Tag = _coor;

            _visible = false;
        }

        public void ChangeColor(int color)
        {
            _color = color;
            if(color == 0)
            {
                _label.BackColor = System.Drawing.Color.LightGray;
            }
            else if (color == 1)
            {
                _label.BackColor = System.Drawing.Color.Green;
            }
            else if (color == 2)
            {
                _label.BackColor = System.Drawing.Color.LightYellow;
            }
            else if (color == 3)
            {
                _label.BackColor = System.Drawing.Color.DarkGray;
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

        public Label ReturnLabel()
        {
            return _label;
        }

        public Label ReturnKnownLabel()
        {
            _label = new Label();
            _label.BorderStyle = BorderStyle.FixedSingle;
            _label.MaximumSize = new System.Drawing.Size(20, 20);
            _label.Margin = new Padding(0, 0, 0, 0);
            _label.Tag = _coor;

            ChangeColor(_color);
            return _label;
        }

        public void setVisible(bool b)
        {
            _visible = b;
        }
    }
}
