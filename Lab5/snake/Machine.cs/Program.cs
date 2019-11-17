using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Machine.cs
{
    class Program
    {
        public static int x = 10, y = 10;
        public static ConsoleKeyInfo pressedKey;
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Thread thread1 = new Thread(new ThreadStart(function));
            thread1.Start();
            while (true) {
                Console.SetCursorPosition(x, y);
                Console.Write('*');
                Thread.Sleep(100);
                Console.Clear();
                switch (pressedKey.Key)
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
        static void Draw(int x, int y)
        { 
            Console.SetCursorPosition(x, y);
            Console.Write('*');
            Console.Clear();
        }
    }
}
