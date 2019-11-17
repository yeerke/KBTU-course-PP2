using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task1
{
    public class ComplexNum
    {
        public double a, b;
        public void PrintInfo()
        {
            Console.WriteLine(a + " + " + b + 'i');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNum));
            FileStream fs = new FileStream("student.txt", FileMode.Create, FileAccess.Write);
            ComplexNum n = new ComplexNum();
            n.a = 5.34;
            n.b = 74.45;
            xs.Serialize(fs, n);
            fs.Close();
            ComplexNum n2 = new ComplexNum();
            XmlSerializer xs2 = new XmlSerializer(typeof(ComplexNum));
            FileStream fs2 = new FileStream("student.txt", FileMode.Open, FileAccess.Read);
            n2 = xs2.Deserialize(fs2) as ComplexNum;
            n2.PrintInfo();
            fs2.Close();
        }
    }
}
