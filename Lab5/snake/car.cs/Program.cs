using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace car.cs
{
    class Program
    {
        public static ConsoleKeyInfo pressedKey;
        public static int x, y;
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(function));
            thread.Start();
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write("*");
                Thread.Sleep(100);
                Console.Clear();
                switch(pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        y--;
                    break;
                    case ConsoleKey.DownArrow:
                        y++;
                    break;
                    case ConsoleKey.LeftArrow:
                        x--;
                    break;
                    case ConsoleKey.RightArrow:
                        x++;
                    break;
                }
            }
        }
        static void function()
        {
            while (true)
            {
                pressedKey = Console.ReadKey();
            }
        }
    }
}
