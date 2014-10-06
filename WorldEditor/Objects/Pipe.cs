using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Pipe
        : Object
    {
        public Pipe(Point _pos = new Point())
            : base("Pipe", _pos)
        {
        }
    }
}
