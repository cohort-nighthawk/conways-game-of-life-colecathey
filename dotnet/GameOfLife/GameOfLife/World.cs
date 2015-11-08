using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World
    {
        // I went width a fixed size world. Might flip this to dynamic later if I can figure it out
        public int worldHeight { get; set; } // setting world grid height
        public int worldWidth { get; set; } // setting world grid width
        
        public void BuildWorld(int height, int width)
        {
            worldHeight = height;
            worldWidth = width;
        }

        

        
    }
}
