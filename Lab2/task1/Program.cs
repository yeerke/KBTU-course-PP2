using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //to read text from files
            FileStream fs = new FileStream(@"C:\Users\Erkebulan\Desktop\file.txt", FileMode.Open, FileAccess.Read); 
            StreamReader s = new StreamReader(fs);
            string l = s.ReadLine(); // saving read files to string l;
            bool k = true;
            for (int i = 0; i < l.Length; i++) // checking for polindrome
            {
                if(l[l.Length-1-i] != l[i])
                {
                    k = false;
                    break;
                }
            }
            if (k == true) Console.WriteLine("YES");
            else Console.WriteLine("NO");
            fs.Close();
            s.Close();
        }
    }
}
