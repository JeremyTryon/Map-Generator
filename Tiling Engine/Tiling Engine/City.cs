using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiling_Engine
{
    class City
    {
        private Cell[,] _grid;
        private List<City> _towns;
        private Tuple<int, int> _coor;

        public City(int x, int y, int size)
        {
            _grid = new Cell[size,size];
            _coor = new Tuple<int, int>(x, y);
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j<size; j++)
                {
                    _grid[i, j] = new Cell(i, j);
                }
            }
            Edit();
        }

        public void Edit()
        {
            //opens map in the editor and sets map to old map
        }

        public Tuple<int,int> GetLocation()
        {
            return _coor;
        }

    }
}
