using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    public class Wall:Gameobject
    {
        public Wall() 
        {
        }
        public void CreateWall(int lvl)
        {
            body.Clear();
            string l = string.Format(@"C:\Users\Erkebulan\Desktop\pp2\Lab5\snake\main\bin\Debug\Levels\Level {0}.txt", lvl);
            FileStream fs = new FileStream(l, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            int j = 0;
            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '#')
                    {
                        Point p = new Point();
                        p.x = i;
                        p.y = j;
                        body.Add(p);
                    }
                }
                j++;
            }
        }
        public bool CollisionWithWall(int x, int y)
        {   
            for(int i = 0; i < body.Count; i++)
            {
                if(body[i].x == x && body[i].y == y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
