using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer(100);
            timer.Elapsed += DoIt;
            timer.Start();
            while (true) { }
        }

        static void DoIt(Object sender, ElapsedEventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
        void DoItt()
        {
            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}
