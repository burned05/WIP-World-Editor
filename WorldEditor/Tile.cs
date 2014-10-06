using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor
{
    public class Tile
    {
        decimal x, y, width, height, tileIndex;

        public decimal TileIndex
        {
            get { return tileIndex; }
            set { tileIndex = value; }
        }

        public decimal Height
        {
            get { return height; }
            set { height = value; }
        }

        public decimal Width
        {
            get { return width; }
            set { width = value; }
        }

        public decimal Y
        {
            get { return y; }
            set { y = value; }
        }

        public decimal X
        {
            get { return x; }
            set { x = value; }
        }
     
    }
    
}
