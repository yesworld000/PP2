using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        public string name;
        public string id;
        public string year;

        public void Info()
        {
            int year1 = int.Parse(year) + 1;
            Console.WriteLine(name + " " + id + " " + year1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student d = new Student();
            d.name = "Damir";
            d.id = "18BD111114";
            d.year = "1";
            d.Info();
        }
    }
}
