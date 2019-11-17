using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Worm : Gameobject
    {
        public bool newlvl = true;
        public int cnt = 0;
        public bool eaten { get; set; }
        public Worm() 
        {
            Point p = new Point();
            p.x = 40;
            p.y = 20;
            body.Add(p);
        }
        public void MoveTo(int dx, int dy, int x, int y)
        {
            CheckCollision(x, y, dx, dy);
            Clear();
            int d;
            if (eaten == false) d = body.Count - 1;            
            else d = body.Count - 2;
            for (int i = d; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;
            foreach (Point p in body)
            {
                if (p.x < 0) p.x = 69;
                else if (p.x >= 70) p.x = 0;
                if (p.y < 0) p.y = 31;
                else if (p.y >= 32) p.y = 0;
            }
            }
        public void CheckCollision(int x, int y, int dx, int dy) 
        {
            if(x == body[0].x+dx && y == body[0].y+dy)
            {
                Point p = new Point();
                p.x = body[body.Count - 1].x;
                p.y = body[body.Count - 1].y;
                body.Add(p);
                eaten = true;
                cnt++;
                if (cnt % 10 == 0)
                {
                    newlvl = true;
                }
            }
        }
        public bool CollisionWithItself()
        {
            for(int i = 1; i < body.Count; i++)
            {
                if(body[0].x == body[i].x && body[0].y == body[i].y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}