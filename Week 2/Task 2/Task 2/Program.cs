
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
        //creating a bool function "IsPrime" which finds out whether a number is prime
        public static bool IsPrime(int a)
        {
            if (a == 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        //returning prime numbers as integers
        static bool IsPrimeString(string s)
        {
            return IsPrime(int.Parse(s));
        }

        static void Main(string[] args)
        {
            //creating a list which contains result
            List<string> res = new List<string>();

            //showing the way to input.txt to open and read it
            FileStream fs = new FileStream(@"C:\Users\Lenovo\Documents\pp2\Week 2\Task 2\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();

            //dividing string to numbers
            string[] nums = line.Split(' ');

            foreach (var x in nums)
            {
                //adding numbers to result if it is prime
                if (IsPrimeString(x))
                {
                    res.Add(x);
                }
            }

            //closing StreamReasder and fileStream
            sr.Close();
            fs.Close();

            //creating new filestream and showing the way to output.txt that will contain the result
            FileStream fs2 = new FileStream(@"C:\Users\Lenovo\Documents\pp2\Week 2\Task 2\output.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);

            foreach (var x in res)
            {
                //writing the result to output.txt
                sw.Write(x + " ");
                Console.Write(x + " ");
            }

            //finishing the work with output.txt
            sw.Close();
            fs2.Close();
        }
    }
}