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
        public bool GiveBirth { get; set; }
        public bool isAlive { get; set; }
        public int neighbors { get; set; }



        //check to see if cell should live to next generation
        public bool IsAlive(int cell_neighbor)
        {            
            if (cell_neighbor < 2 || cell_neighbor >= 4)
            {
                isAlive = false;
                return isAlive;
            }
            else
            {
                isAlive = true;
                return isAlive;
            }
        }

        //check to see if cell should replicate next generation
        public bool CellReplicate(int cell_neighbor)
        {
            if (cell_neighbor < 2 || cell_neighbor >= 4)
            {
                GiveBirth = false;
                return GiveBirth;
            }
            else
            {
                GiveBirth = true;
                return GiveBirth;
            }
        }
    }
}
