using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiling_Engine
{
    class World
    {
        private Cell[,] _grid;
        private List<City> _citys;
        private int _mouseColor;
        private const int _citysize = 30;

        public World()
        {
            for(int i = 0; i<50; i++)
            {
                for(int j =0; j<50; j++)
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

    }
}
