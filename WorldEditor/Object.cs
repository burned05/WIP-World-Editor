using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEditor
{
    struct Point
    {
        decimal x, y;
        public Point(decimal _x = 0, decimal _y = 0)
        {
            x = _x;
            y = _y;
        }
    }
    class Object
    {
        String type;
        Point position;

        public Object(string _type = "Object", Point _pos = new Point())
        {
            type = _type;
            position = _pos;
        }
        public override string ToString()
        {
            return type;
        }

    }
}
