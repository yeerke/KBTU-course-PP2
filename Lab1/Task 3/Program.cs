using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void f(string[] s1, string[] s2)// method that makes out of an array of integers another array of integers, where every element is repeated
        {
            for(int i = 0; i < s2.Length; i++)
            {
                s2[i] = s1[i/2];
            }
            for(int i = 0; i < s2.Length; i++)
            {
                Console.Write(s2[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] p = s.Split(); //initial array of strings
            string[] q = new string[2 * n];//new array that saves double values
            f(p, q);//calling function
        }
    }
}