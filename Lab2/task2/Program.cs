using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace task2
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
            FileStream fs = new FileStream(@"C:\Users\Erkebulan\Desktop\input.txt", FileMode.Open, FileAccess.Read);//reading file
            StreamReader r = new StreamReader(fs);
            string l = r.ReadLine(); //saving file into string l
            char[] del = new char[] { ' ' };
            string[] a = l.Split(del, StringSplitOptions.RemoveEmptyEntries); // spliting string into substrings without space and saving them into array
            int[] b = new int[a.Length];
            for(int i = 0; i < a.Length; i++)
            {
                b[i] = int.Parse(a[i]); // converting string into integers
            }
            string path = @"C: \Users\Erkebulan\Desktop\output.txt";
            File.Create(path).Close();
            FileStream fs2 = new FileStream(path, FileMode.Append, FileAccess.Write); // file for writing
            StreamWriter w = new StreamWriter(fs2);     
            for (int i = 0; i < b.Length; i++)
            {
                if (f(b[i]) == true)
                {
                    w.Write(b[i] + " "); // writing actually
                }

            }
            w.Close();
            fs.Close();
            r.Close();
        }
    }
}
