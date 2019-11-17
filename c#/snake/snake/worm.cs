using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    
    class Worm
    {
        public int dx = 0, dy = 0;
        public List<Point> body = new List<Point>();
        public Worm(int x, int y)
        {
            body.Add(new Point(x, y));
        }
        public void Move()
        {
            for(int i = body.Count-1; i > 0; i--)
            {
                body[i].x = body[i-1].x;
                body[i].y = body[i-1].y;
            }
            body[0].x += dx;
            body[0].y += dy;
        }
        public bool IsEaten(int x, int y)
        {
            if (body[0].x + dx == x && body[0].y + dy == y)
            {
                body.Add(new Point(x, y));
                return true;
            }
            else return false;
        }
    }
}
