using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student
    {
        //creating name, id and year of a student
        public string name;
        public string id;
        public string year;

        public void Info()
        {
            //showing info about student(including next year of education)
            int year1 = int.Parse(year) + 1;
            Console.WriteLine(name + " " + id + " " + year1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //giving info about a student
            Student d = new Student();
            d.name = "Damir";
            d.id = "18BD111114";
            d.year = "1";

            d.Info();
        }
    }
}
