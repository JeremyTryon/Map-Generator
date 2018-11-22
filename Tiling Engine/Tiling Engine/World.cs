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

        public World(Cell[,] g, List<City> c, int size)
        {
            _grid = g;
            _citys = c;
            _size = size;
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
        }

        public void CellClick(int x, int y)
        {
            _grid[x, y].ChangeColor(_mouseColor);
        }

        public bool ReturnVisiblity(int x, int y)
        {
            return _grid[x, y].IsVisible();
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

        public int ReturnSize()
        {
            return _size;
        }

    }
}
