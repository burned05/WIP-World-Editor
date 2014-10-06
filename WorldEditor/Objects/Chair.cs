using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Chair
        : Object
    {
        public Chair(Point _pos = new Point())
            : base("Chair", _pos)
        {
        }
    }
}
