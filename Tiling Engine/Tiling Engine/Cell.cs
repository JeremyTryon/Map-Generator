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
        private int _color;
        private int[] _surColors = { 0, 0, 0, 0, 0, 0 };

        public Cell(int x, int y)
        {
            _coor = new Tuple<int, int>(x, y);
            _color = 0;

            _label = new Label();
            _label.BackColor = System.Drawing.Color.DarkGray;
            _label.BorderStyle = BorderStyle.FixedSingle;
            _label.MaximumSize = new System.Drawing.Size(20, 20);
            _label.Margin = new Padding(0, 0, 0, 0);
            _label.Tag = _coor;

            _visible = true;
        }

        public void ChangeColor(int color)
        {
            
            if(color == 0)
            {
                _color = color;
                setVisible(true);
                _label.BackColor = System.Drawing.Color.DarkGray;
            }
            else if (color == 1)
            {
                _color = color;
                setVisible(true);
                _label.BackColor = System.Drawing.Color.Green;
            }
            else if (color == 2)
            {
                _color = color;
                setVisible(true);
                _label.BackColor = System.Drawing.Color.Yellow;
            }
            else if (color == 3)
            {
                _color = color;
                setVisible(true);
                _label.BackColor = System.Drawing.Color.Brown;
            }
            else if (color == 4)
            {
                _color = color;
                setVisible(true);
                _label.BackColor = System.Drawing.Color.Blue;
            }
            else if (color == 5)
            {
                _color = color;
                setVisible(true);
                _label.BackColor = System.Drawing.Color.White;
            }
            else if (color == 6)
            {
                setVisible(true);
                if (_color == 1)
                {
                    _label.BackColor = System.Drawing.Color.Green;
                }
                else if (_color == 2)
                {
                    _label.BackColor = System.Drawing.Color.Yellow;
                }
                else if (_color == 3)
                {
                    _label.BackColor = System.Drawing.Color.Brown;
                }
                else if (_color == 4)
                {
                    _label.BackColor = System.Drawing.Color.Blue;
                }
                else if (_color == 5)
                {
                    _label.BackColor = System.Drawing.Color.White;
                }
            }
            else if (color == 7)
            {
                setVisible(false);
                if (_color == 1)
                {
                    _label.BackColor = System.Drawing.Color.FromArgb(100, Color.Green);
                }
                else if (_color == 2)
                {
                    _label.BackColor = System.Drawing.Color.Orange;
                    //_label.BackColor = System.Drawing.Color.FromArgb(100, Color.Yellow);
                }
                else if (_color == 3)
                {
                    _label.BackColor = System.Drawing.Color.FromArgb(100, Color.Brown);
                }
                else if (_color == 4)
                {
                    _label.BackColor = System.Drawing.Color.FromArgb(100, Color.Blue);
                }
                else if (_color == 5)
                {
                    _label.BackColor = System.Drawing.Color.LightGray;
                }
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
            if (IsVisible())
            {
                ChangeColor(6);
            }
            else
            {
                ChangeColor(7);
            }
            return _label;
        }

        public void setVisible(bool b)
        {
            _visible = b;
        }
        public int ReturnColor()
        {
            return _color;
        }

        public void RemoveColor(int color)
        {

            if (color < 5)
            {
                _surColors[color] -= 1;
            } 
        }

        public void AddColor(int color)
        {
            if (color < 5)
            {
                _surColors[color] += 1;
            }
        }

        public int[] RetCA()
        {
            return _surColors;
        }
    }
}
