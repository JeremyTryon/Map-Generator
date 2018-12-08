using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiling_Engine
{
    [Serializable]
    public class World
    {
        private Cell[,] _grid;
        private List<City> _citys;
        private int _mouseColor;
        private int _size;
        private const int _citysize = 30;

        public World()
        {
            uxSizeInput dlg = new uxSizeInput();

            dlg.ShowDialog();           
            _size = dlg.GetSize();

            _grid = new Cell[_size, _size];
            for(int i = 0; i<_size; i++)
            {
                for(int j =0; j<_size; j++)
                {
                    _grid[i, j] = new Cell(i, j);
                }
            }
            _citys = new List<City>();
        }

        public World(int size)
        {
            _size = size;
            _grid = new Cell[_size, _size];
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    _grid[i, j] = new Cell(i, j);
                }
            }
            _citys = new List<City>();
        }

        public bool ReturnVisiblity(int x, int y)
        {
            return _grid[x, y].IsVisible();
        }

        public int ReturnSize()
        {
            return _size;
        }

        public Label ReturnLabel(int x, int y)
        {
            return _grid[x, y].ReturnLabel();
        }

        public Label ReturnKnownLabel(int x, int y)
        {
            return _grid[x, y].ReturnKnownLabel();
        }

        public void SetMouseColor(int c)
        {
            _mouseColor = c;
        }

        public void Generate()
        {
            //fills in the rest of the world
            int oldmouse = _mouseColor;
            Random r = new Random();
            for (int i = 0; i<_size; i++)
            {
                for(int j=0; j<_size; j++)
                {
                    if(_grid[i,j].ReturnColor() == 0)
                    {
                        int grassVal = 5;
                        int desertVal = 5;
                        int mountainVal = 5;
                        int oceanVal = 5;
                        int tundraVal = 5;
                        int[] surVals = _grid[i,j].RetCA();

                        if ((i < (_size / 7)))
                        {
                            tundraVal += 250;
                        }    
                            
                        if(i > (_size - (_size / 7)))
                        {
                            tundraVal += 600;
                        }

                        if ((i < (3 * (_size / 5))) && (i > (2 * (_size / 5))))
                        {
                            desertVal += 80;
                        }

                        if ((j < (_size / 5)) || (j > (_size - (_size / 5))))
                        {
                            oceanVal += 75;
                        }

                        if ((j < (3 * (_size / 5))) && (j > (2 * (_size / 5))))
                        {
                            mountainVal += 30;
                        }

                        for(int g =0; g<surVals[1]; g++)
                        {
                            grassVal += 200;
                        }
                        for(int d = 0; d<surVals[2]; d++)
                        {
                            desertVal += 140;
                        }
                        for(int m = 0; m<surVals[3]; m++)
                        {
                            mountainVal += 150;
                        }
                        for(int o =0; o<surVals[4]; o++)
                        {
                            oceanVal += 140;
                        }
                        for(int t=0; t<surVals[5]; t++)
                        {
                            tundraVal += 250;
                        }

                        //color change
                        double total = grassVal + desertVal + mountainVal + oceanVal + tundraVal;

                        List<KeyValuePair<int, double>> probColors = new List<KeyValuePair<int, double>>();
                        probColors.Add(new KeyValuePair<int, double>(0, grassVal / total));
                        probColors.Add(new KeyValuePair<int, double>(1, desertVal / total));
                        probColors.Add(new KeyValuePair<int, double>(2, mountainVal / total));
                        probColors.Add(new KeyValuePair<int, double>(3, oceanVal / total));
                        probColors.Add(new KeyValuePair<int, double>(4, tundraVal / total));

                        double rnd = r.NextDouble();

                        double sum = 0.0;
                        for (int k = 0; k < probColors.Count; k++)
                        {
                            sum += probColors[k].Value;
                            if (rnd < sum)
                            {
                                _mouseColor = probColors[k].Key + 1;
                                CellClick(i, j);
                                k = probColors.Count;
                            }
                        }
                    }
                }
            }
            _mouseColor= oldmouse;
        }

        public void CellClick(int x, int y)
        {
            int oldColor = _grid[x, y].ReturnColor();
            _grid[x, y].ChangeColor(_mouseColor);

            //remove the old color
            if(oldColor != 0)
            {
                if (x == 0)
                {
                    _grid[x+1, y].RemoveColor(oldColor);
                    if (y == 0)
                    {
                        _grid[x, y+1].RemoveColor(oldColor);
                        _grid[x+1, y+1].RemoveColor(oldColor);
                    }
                    else if (y == _size-1)
                    {
                        _grid[x, y-1].RemoveColor(oldColor);
                        _grid[x + 1, y-1].RemoveColor(oldColor);
                    }
                    else
                    {
                        _grid[x, y + 1].RemoveColor(oldColor);
                        _grid[x + 1, y + 1].RemoveColor(oldColor);
                        _grid[x, y - 1].RemoveColor(oldColor);
                        _grid[x + 1, y - 1].RemoveColor(oldColor);
                    }
                }
                else if(x == _size - 1)
                {
                    _grid[x-1, y].RemoveColor(oldColor);
                    if (y == 0)
                    {
                        _grid[x, y + 1].RemoveColor(oldColor);
                        _grid[x-1, y + 1].RemoveColor(oldColor);
                    }
                    else if (y == _size - 1)
                    {
                        _grid[x, y - 1].RemoveColor(oldColor);
                        _grid[x- 1, y - 1].RemoveColor(oldColor);
                    }
                    else
                    {
                        _grid[x, y + 1].RemoveColor(oldColor);
                        _grid[x-1, y + 1].RemoveColor(oldColor);
                        _grid[x, y - 1].RemoveColor(oldColor);
                        _grid[x-1, y - 1].RemoveColor(oldColor);
                    }
                }
                else if(y==0){
                    _grid[x + 1, y].RemoveColor(oldColor);
                    _grid[x, y + 1].RemoveColor(oldColor);
                    _grid[x + 1, y + 1].RemoveColor(oldColor);
                    _grid[x - 1, y].RemoveColor(oldColor);
                    _grid[x - 1, y + 1].RemoveColor(oldColor);
                }
                else if (y == _size - 1)
                {
                    _grid[x + 1, y].RemoveColor(oldColor);
                    _grid[x, y - 1].RemoveColor(oldColor);
                    _grid[x + 1, y - 1].RemoveColor(oldColor);
                    _grid[x - 1, y].RemoveColor(oldColor);
                    _grid[x - 1, y - 1].RemoveColor(oldColor);
                }
                else
                {
                    _grid[x + 1, y].RemoveColor(oldColor);
                    _grid[x, y + 1].RemoveColor(oldColor);
                    _grid[x + 1, y + 1].RemoveColor(oldColor);
                    _grid[x, y - 1].RemoveColor(oldColor);
                    _grid[x + 1, y - 1].RemoveColor(oldColor);
                    _grid[x - 1, y].RemoveColor(oldColor);
                    _grid[x - 1, y - 1].RemoveColor(oldColor);
                    _grid[x - 1, y + 1].RemoveColor(oldColor);
                }
            }


            //add the new color
            if (x == 0)
            {
                _grid[x + 1, y].AddColor(_mouseColor);
                if (y == 0)
                {
                    _grid[x, y + 1].AddColor(_mouseColor);
                    _grid[x + 1, y + 1].AddColor(_mouseColor);
                }
                else if (y == _size - 1)
                {
                    _grid[x, y - 1].AddColor(_mouseColor);
                    _grid[x + 1, y - 1].AddColor(_mouseColor);
                }
                else
                {
                    _grid[x, y + 1].AddColor(_mouseColor); //here is the problem
                    _grid[x + 1, y + 1].AddColor(_mouseColor);
                    _grid[x, y - 1].AddColor(_mouseColor);
                    _grid[x + 1, y - 1].AddColor(_mouseColor);
                }
            }
            else if (x == _size - 1)
            {
                _grid[x - 1, y].AddColor(_mouseColor);
                if (y == 0)
                {
                    _grid[x, y + 1].AddColor(_mouseColor);
                    _grid[x - 1, y + 1].AddColor(_mouseColor);
                }
                else if (y == _size - 1)
                {
                    _grid[x, y - 1].AddColor(_mouseColor);
                    _grid[x - 1, y - 1].AddColor(_mouseColor);
                }
                else
                {
                    _grid[x, y + 1].AddColor(_mouseColor);
                    _grid[x - 1, y + 1].AddColor(_mouseColor);
                    _grid[x, y - 1].AddColor(_mouseColor);
                    _grid[x - 1, y - 1].AddColor(_mouseColor);
                }
            }
            else if (y == 0)
            {
                _grid[x + 1, y].AddColor(_mouseColor);
                _grid[x, y + 1].AddColor(_mouseColor);
                _grid[x + 1, y + 1].AddColor(_mouseColor);
                _grid[x - 1, y].AddColor(_mouseColor);
                _grid[x - 1, y + 1].AddColor(_mouseColor);
            }
            else if (y == _size - 1)
            {
                _grid[x + 1, y].AddColor(_mouseColor);
                _grid[x, y - 1].AddColor(_mouseColor);
                _grid[x + 1, y - 1].AddColor(_mouseColor);
                _grid[x - 1, y].AddColor(_mouseColor);
                _grid[x - 1, y - 1].AddColor(_mouseColor);
            }
            else
            {
                _grid[x + 1, y].AddColor(_mouseColor);
                _grid[x, y + 1].AddColor(_mouseColor);
                _grid[x + 1, y + 1].AddColor(_mouseColor);
                _grid[x, y - 1].AddColor(_mouseColor);
                _grid[x + 1, y - 1].AddColor(_mouseColor);
                _grid[x - 1, y].AddColor(_mouseColor);
                _grid[x - 1, y - 1].AddColor(_mouseColor);
                _grid[x - 1, y + 1].AddColor(_mouseColor);
            }
        }

        public void CreateCity(int x, int y)
        {
            _citys.Add(new City(x, y, _citysize));
        }

        public void EditCity(int x, int y)
        {
            Tuple<int, int> temp = new Tuple<int, int>(x, y);
            _citys.Find(c => c.GetLocation() == temp);
            //send city to editor
            _citys.RemoveAll(c => c.GetLocation() == temp);
            //readd it
        }

        public void RemoveCity(int x, int y)
        {
            Tuple<int, int> temp = new Tuple<int, int>(x, y);
            _citys.RemoveAll(c => c.GetLocation() == temp);
        }
    }
}
