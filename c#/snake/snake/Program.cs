using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Wall()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (j == 0 || j == 19)
                    {
                        Console.Write("#");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("#");
            }
        }
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.Clear();
                Wall();
            }
        }
    }
}
