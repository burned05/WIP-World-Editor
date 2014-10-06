using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Tree : Object
    {
        public Tree(Point _pos = new Point())
            : base("Tree", _pos)
        {
        }
    }
}
