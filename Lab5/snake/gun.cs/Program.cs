using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gun.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 30);
            Console.SetBufferSize(60, 30);
            Console.CursorVisible = false;
            Console.WriteLine("********");
            Console.WriteLine("**");
            Console.WriteLine("*");
            while (true)
            {
                ConsoleKeyInfo pressedkey = Console.ReadKey();
                if(pressedkey.Key == ConsoleKey.Spacebar)
                {
                    Thread thread = new Thread(new ThreadStart(function));
                    thread.Start();
                }
            }
        } 
        static void function()
        {
            int x = 8;
            while(x <= 59)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write(" *");
                Thread.Sleep(100);
                x++;
            }
        }
    }
}
