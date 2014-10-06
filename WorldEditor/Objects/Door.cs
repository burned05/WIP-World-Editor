using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Door : Object
    {
        bool open = false;
        public Door(Point _pos = new Point())
            : base("Door", _pos)
        {
        }
    }
}
