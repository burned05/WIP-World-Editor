using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Couch : Object
    {
        public Couch(Point _pos = new Point())
            : base("Couch", _pos)
        {
        }
    }
}
