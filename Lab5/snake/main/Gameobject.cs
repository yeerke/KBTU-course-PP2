using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public abstract class Gameobject
    {
        public Gameobject()
        {
        }
        public char sign { get; set; }
        public List<Point> body = new List<Point>();
        public void Draw()
        {
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                if (sign == 'o')
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    if (p == body[0])
                    {
                        Console.Write('O');
                    }
                    else Console.Write(sign);
                }
                else
                {
                    if (sign == '#') Console.ForegroundColor = ConsoleColor.Red;
                    else Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(sign);
                }
            }
        }
        public void Clear()
        {
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(' ');
            }
        }
    }
}
