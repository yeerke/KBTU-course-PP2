using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class student
    {
        private string name;
        private string id;
        private int year;
        public student(string NAME, string ID, int Year)
        {
            name = NAME;
            id = ID;
            year = Year;
        }
        public void output()
        {
            Console.WriteLine(name + " " + id + " " + " " + year);
        }
        public int increment()
        {
            return year++;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string i = Console.ReadLine();
            int y = int.Parse(Console.ReadLine());
            student s1 = new student(s, i, y);
            s1.increment();
            s1.output();
        }
    }
}
