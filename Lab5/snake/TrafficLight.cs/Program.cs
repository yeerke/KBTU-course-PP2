using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TrafficLight.cs
{
    class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        public static List<Point> form = new List<Point>();
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\Erkebulan\Desktop\pp2\Lab5\snake\TrafficLight.cs\bin\Debug\form\light.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader r = new StreamReader(fs);
            int j = 0;
            while (!r.EndOfStream)
            {
                string s = r.ReadLine();
                for(int i = 0; i < s.Length; i++)
                {
                    if(s[i] == '*')
                    {
                        form.Add(new Point(i, j));
                    }
                }
                j++;
            }
            Thread thread1 = new Thread(new ThreadStart(Red));
            thread1.Start();
            Thread.Sleep(2050);
            Thread thread2 = new Thread(new ThreadStart(Green));
            thread2.Start();
            Thread.Sleep(2050);
            Thread thread3 = new Thread(new ThreadStart(Yellow));
            thread3.Start();

        }
        static void Red()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < form.Count; i++)
                {
                    Console.SetCursorPosition(form[i].x, form[i].y);
                    Console.Write('*');
                }
                Thread.Sleep(2000);
                Console.Clear();
                Thread.Sleep(4150);
            }
        }
        static void Green()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < form.Count; i++)
                {
                    Console.SetCursorPosition(form[i].x, form[i].y + 4);
                    Console.Write('*');
                }
                Thread.Sleep(2000);
                Console.Clear();
                Thread.Sleep(4150);
            }
        }
        static void Yellow()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 0; i < form.Count; i++)
                {
                    Console.SetCursorPosition(form[i].x, form[i].y + 8);
                    Console.Write('*');
                }
                Thread.Sleep(2000);
                Console.Clear();
                Thread.Sleep(4150);
            }

        }
    }
}
