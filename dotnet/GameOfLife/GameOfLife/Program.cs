using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class World
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
            Size = size;
            _world = new int[size, size];
            _nextGeneration = new int[size, size];
            return Size;
        }

        public int this[int x, int y]
        {
            get { return _world[x, y]; }
            set { _world[x, y] = value; }
        }

        public Action<int[,]> NextGenerationCompleted;

        //public int Cell(int x,int y)
        //{
        //    var cellLocation = _world[x, y];
        //    return _world[x, y] = cellLocation;
        //}

        

    }

    //building cell
    public class Cell
    {
        
        //holder for position of cell
        public int [,] CellLocation;
        //how many neighbors cell has
        public int Neighbors;



        public bool IsAlive()
        {
            if (Neighbors < 2 || Neighbors > 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
