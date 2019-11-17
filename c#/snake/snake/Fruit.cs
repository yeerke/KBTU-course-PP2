using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Fruit
    {
        Random rand = new Random(DateTime.Now.Second);
        public Point point;
        public Fruit(int w, int h)
        {
            int x = rand.Next(0, w);
            x = x / 5;
            x *= 5;
            int y = rand.Next(0, h);
            y = y / 5;
            y *= 5;
            point = new Point(x, y);
        }

    }
}
