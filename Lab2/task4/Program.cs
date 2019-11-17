using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Console.ReadLine(); // naming new file
            string path1 = @"C:\Users\Erkebulan\Desktop\pp2"; // initial path where we will create new file
            string path2 = @"C:\Users\Erkebulan\Desktop\calculus"; // path where we will copy created file
            string sourcefile = Path.Combine(path1, filename); // command for combing name of file and path where we will create
            string destfile = Path.Combine(path2, filename); // its like string destfile = path2 + "//" + filename
            FileStream fs = File.Create(sourcefile); // actually creating it
            fs.Close(); // closing stream because we will use it to copy
            File.Copy(sourcefile, destfile, true); // copy
            File.Delete(sourcefile); // deleting

        }
    }
}
