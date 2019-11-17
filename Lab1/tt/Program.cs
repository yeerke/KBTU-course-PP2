using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static bool f(int n) // bool function that checks for prime; if the number prime f returns true, else returns false
        {
            if (n <= 1) return false;
            else
            {
                bool k = true;
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        k = false;
                        break;
                    }
                }
                return k;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = s.Split(); //split nums from spaces
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(a[i]); //convert string of nums to int type
            }
            int cnt = 0; // number for counting how many prime is here
            for (int i = 0; i < n; i++)
            {
                if (f(b[i]) == true) cnt++;
                else b[i] = 0; // while going through with "for" loop to output each prime, to do not check the number for prime twice
                //i mark not prime nums with equalling them to 0
                //because checking for prime takes long time
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                // all non-zero nums are primes
                if (b[i] != 0) Console.Write(b[i] + " ");
            }
        }
    }
}