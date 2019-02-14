using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathString = @"C:\Users\Lenovo\Documents\pp2\Week 2\Task 4\Path";

            string fileName = "file1.txt";

            pathString = System.IO.Path.Combine(pathString, fileName);

            if (!System.IO.File.Exists(pathString))
            {
                using (System.IO.FileStream fs = System.IO.File.Create(pathString));
            }

            try
            {
                byte[] readBuffer = System.IO.File.ReadAllBytes(pathString);
                foreach (byte b in readBuffer)
                {
                    Console.Write(b + " ");
                }
                Console.WriteLine();
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine(e.Message);
            }

            System.Console.ReadKey();
        }
    }
}
