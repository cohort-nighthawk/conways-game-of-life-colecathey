using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Life
    {
        private int[,] _world;
        private int[,] _nextGeneration;
        //private Task processTask;

        public int Size { get; set; }
        public int Generation { get; set; }

        public int WorldSize(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Size must be 1 or larger");
            }
            else
            {
                this.Size = size;
                _world = new int[size, size];
                _nextGeneration = new int[size, size];
                return Size;

            }
        }

        public int this[int x, int y]
        {
            get { return this._world[x, y]; }
            set { this._world[x, y] = value; }
        }

        public Action<bool[,]> NextGenerationCompleted;

        public int Cell(int x,int y)
        {
            //bool isAlive = true;
            int cellLocation = this._world[x, y];
            return this._world[x, y] = cellLocation;
        }
    }
}
