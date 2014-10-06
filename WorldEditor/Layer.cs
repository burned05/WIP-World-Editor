using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor
{
    
    class Layer
    {
        string name;
        decimal level;
        List<Tile> tiles;

        public Layer(string _name, decimal _level)
        {
            name = _name;
            level = _level;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
