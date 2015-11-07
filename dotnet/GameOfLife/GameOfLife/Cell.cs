using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Cell
    {
        //holder for position of cell
        public int[,] CellLocation { get; set; }
        public int Neighbors { get; set; }
        public bool AliveCell { get; set; }



        public bool IsAlive(int Neighbors)
        {
            //var aliveCell = true;
            if (Neighbors < 2 || Neighbors > 4)
            {
                AliveCell = false;
                return AliveCell;
            }
            else
            {
                AliveCell = true;
                return AliveCell;
            }
        }
    }
}
