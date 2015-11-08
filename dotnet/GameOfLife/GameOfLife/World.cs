using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World
    {
        private int[,] _world;
        private int[,] _nextGeneration;

        //private Task processTask;

        public static int Size { get; set; }
        public int Generation { get; set; }

        public int BuildWorldSize(int world_size)
        {
            _world. = world_size; 
        }
    }
}
