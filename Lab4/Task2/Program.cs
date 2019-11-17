using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    public class Mark
    {
        public int p;
        public string GetLetter()
        {
            if (p > 94) return "A";
            else
            {
                if (p > 89 && p < 95) return "A-";
                else
                {
                    if (p < 89 && p > 84) return "B+";
                    else
                    {
                        if (p > 74 && p < 80) return "B";
                        else
                        {
                            if (p < 75 && p > 69) return "B-";
                            else
                            {
                                if (p > 64 && p < 70) return "C+";
                                else
                                {
                                    if (p < 65 && p > 59) return "C";
                                    else
                                    {
                                        if (p < 60 && p > 54) return "C-";
                                        else
                                        {
                                            return "F";
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Mark> l = new List<Mark>();
            Random rnd = new Random(DateTime.Now.Second);

            for (int i = 0; i < 100; i++)
            {
                Mark m = new Mark();
                m.p = rnd.Next(0, 100);
                l.Add(m);
            }
            XmlSerializer xml = new XmlSerializer(typeof(List<Mark>));
            FileStream fs = new FileStream("Mark.txt", FileMode.Create, FileAccess.Write);
            xml.Serialize(fs, l);
            fs.Close();
            XmlSerializer xs2 = new XmlSerializer(typeof(List<Mark>));
            FileStream fs2 = new FileStream("Mark.txt", FileMode.Open, FileAccess.Read);
            List<Mark> l2 = xs2.Deserialize(fs2) as List<Mark>;
            for(int i = 0; i < l2.Count; i++)
            {
                Console.WriteLine(l2[i].p + " = " + l2[i].GetLetter());
            }
        }
    }
}
