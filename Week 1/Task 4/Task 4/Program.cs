using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating size of a triangle
            string s = Console.ReadLine();
            int n = int.Parse(s);

            //making coordinates, i and j
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //giving coordinates where [*] will be
                    if (i >= j) Console.Write("[*]");
                }
                Console.Write("\n");
            }
        }
    }
}
