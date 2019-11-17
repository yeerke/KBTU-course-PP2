using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Fruit:Gameobject
    {
        Random rand = new Random(DateTime.Now.Second);
        public Fruit()
        {
        }
        public void generateLoc(List<Point> wall, List<Point> worm)
        {
            body.Clear();

            Point p = new Point();
            p.x = rand.Next(0, 69);
            p.y = rand.Next(0, 31);
            while(IsGoodPoint(wall, p, worm) == false)
            {
                p.x = rand.Next(0, 69);
                p.y = rand.Next(0, 31);
            }
            body.Add(p);
        }
        public bool IsGoodPoint(List<Point> wall, Point f, List<Point> worm)
        {
            foreach(Point p in wall)
            {
                if(f.x == p.x && f.y == p.y)
                {
                    return false;
                }
            }
            foreach (Point p in worm)
            {
                if (f.x == p.x && f.y == p.y)
                {
                    return false;
                }
            }
            return true;
        }
        
    }
}
