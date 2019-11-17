using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static string s = "   ";
        static void f(DirectoryInfo dir, int k)//recursive function that prints info about directory
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;//folders are yellow
            for(int i = 0; i < k; i++)
            {
                Console.Write(s);
            }
            Console.WriteLine(dir.Name);//function prints the name of directory first
            var x = dir.GetFileSystemInfos();
            foreach (var t in x)
            {
                if (t.GetType() == typeof(DirectoryInfo))//if its directory we call function with more spaces
                {
                    DirectoryInfo y = t as DirectoryInfo;
                    f(y, k+1);
                }
                if (t.GetType() == typeof(FileInfo))//if its file its just print the name of file
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    for(int i = 0; i < k+1; i++)
                    {
                        Console.Write(s);
                    }
                    Console.WriteLine(t);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\Erkebulan\Desktop\ACM\ACM ICPC");
            f(dirinfo, 0);//calling function
        }       
    }
}
