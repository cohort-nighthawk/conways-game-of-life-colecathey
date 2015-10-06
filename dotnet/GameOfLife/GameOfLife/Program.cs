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
        private bool[,] world;
        private bool[,] nextGeneration;
        private Task processTask;

        public int Size { get; set; }
        public int Generation { get; set; }

        public void WorldSize(int size)
        {
            if(size < 1) throw new ArgumentException("Size must be 1 or larger");
            this.Size = size;
            world = new bool[size, size];
            nextGeneration = new bool[size, size];            
        }

        public bool this[int x, int y]
        {
            get { return this.world[x, y]; }
            set { this.world[x, y] = value; }
        }

        public Action<bool[,]> NextGenerationCompleted;

        public bool Cell(int x,int y)
        {
            bool currentValue = this.world[x, y];
            return this.world[x, y] = !currentValue;
        }
    }
}
