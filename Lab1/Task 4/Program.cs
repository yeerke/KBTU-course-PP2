using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = "[*]";
            string[,] a = new string[n, n]; // creating 2D array which consist of string
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= i) a[i, j] = s; // giving the value
                    else a[i, j] = "";
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]); // outputing
                }
                Console.WriteLine(); //moving to another line
            }
        }
    }
}





