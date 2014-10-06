using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor.Objects
{
    class Table : Object
    {
        public Table(Point _pos = new Point())
            : base("Table", _pos)
        {
        }
    }
}
