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
        static void Main(string[] args)
        {
            f4();
        }


        static void f4()
        {
            DirectoryInfo dirinfo4 = new DirectoryInfo(@"C:\Users\Erkebulan\Desktop\ACM");
            FileSystemInfo[] x4 = dirinfo4.GetFiles();
            for (int i = 0; i < x4.Length; i++)
            {
                Console.WriteLine(x4[i].Name);
            }
        }


        static void f3()
        {
           DirectoryInfo dirinfo3 = new DirectoryInfo(@"C:\Users\Erkebulan\Desktop\ACM");
            var x3 = dirinfo3.GetFileSystemInfos();
            foreach (var t in x3)
            {
                if (t.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                if (t.GetType() == typeof(FileInfo))

                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                Console.WriteLine(t.Name);
            }
        }
        static void f2()
        {
            DirectoryInfo dirinfo2 = new DirectoryInfo(@"C:\Users\Erkebulan\Desktop\ACM");
            var x2 = dirinfo2.GetFileSystemInfos();
            foreach (var t in x2)
            {
                Console.WriteLine(t.Name);
            }
        }
        static void f1()
        {
            DirectoryInfo dirinfo1 = new DirectoryInfo(@"C:\Users\Erkebulan\Desktop\ACM");
            FileSystemInfo[] x1 = dirinfo1.GetFileSystemInfos();
            for (int i = 0; i < x1.Length; i++)
            {
                Console.WriteLine(x1[i]);
            }                
        }
    }
}
