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
            string s = Console.ReadLine();
            int n = int.Parse(s);

            /*int[] a = new int[n];

            string[] nums = Console.ReadLine().Split(new char[] { ',', ';', '#', ' ' });
            */
            for(int i=0; i<n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j) Console.Write("[*]");
                }
                Console.Write("\n");
            }
        }
    }
}
