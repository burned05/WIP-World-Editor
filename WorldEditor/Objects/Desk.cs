using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Desk : Object
    {
        public Desk(Point _pos = new Point())
            : base("Desk", _pos)
        {
        }
    }
}
