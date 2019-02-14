
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static bool IsPrime(int a)
        {
            if (a == 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        static bool IsPrimeString(string s)
        {
            return IsPrime(int.Parse(s));
        }

        static void Main(string[] args)
        {

            List<string> res = new List<string>();

            FileStream fs = new FileStream(@"C:\Users\Lenovo\Documents\pp2\Week 2\Task 2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            string[] nums = line.Split(' ');

            foreach (var x in nums)
            {
                if (IsPrimeString(x))
                {
                    res.Add(x);
                }
            }

            sr.Close();
            fs.Close();
            FileStream fs2 = new FileStream(@"C:\Users\Lenovo\Documents\pp2\Week 2\Task 2\output.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);

            foreach (var x in res)
            {
                sw.Write(x + " ");
                Console.Write(x + " ");
            }
            sw.Close();
            fs2.Close();
        }
    }
}