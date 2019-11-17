using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            char[] del = new char[] { ' ' };
            string[] s = line.Split(del, StringSplitOptions.RemoveEmptyEntries);
            int[] a = new int[n];
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(s[i]);
            }
            int max = -1000000;
            for(int i = 0; i < n; i++)
            {
                for(int j = i+1; j < n; j++)
                {
                    if(a[i] == a[j])
                    {
                        if (max < a[i]) max = a[i];
                        break;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
