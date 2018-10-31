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
        private int _size = 50;
        private const int _citysize = 30;

        public World()
        {
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

        public World(Cell[,] g, List<City> c)
        {
            _grid = g;
            _citys = c;
        }

        public Label ReturnLabel(int x, int y)
        {
            return _grid[x, y].ReturnLabel();
        }

        public void SetMouseColor(int c)
        {
            _mouseColor = c;
        }

        public void Generate()
        {
            //fills in the rest of the world
        }

        public void CellClick(int x, int y)
        {
            _grid[x, y].ChangeColor(_mouseColor);
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

        public void HideCell(int x, int y, bool b)
        {
            _grid[x, y].setVisible(b);
        }

        public int ReturnSize()
        {
            return _size;
        }

    }
}
