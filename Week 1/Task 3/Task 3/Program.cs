using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        //making a function that dublicates numbers
        private static void dublicate(string[] s, int n)
        {
            //our result is a string which is twice bigger
            string[] s2 = new string[n * 2];

            //dublicating
            for (int i = 0, j = 0; i < n; ++i)
            {
                s2[j++] = s[i];
                s2[j++] = s[i];
            }

            //showing result to the screen
            for (int i = 0; i < 2 * n; ++i)
                Console.Write(s2[i] + " ");
        }


        static void Main(string[] args)
        {
            //creating integer
            int n = int.Parse(Console.ReadLine());

            //reading an array with numbers
            string[] s = Console.ReadLine().Split();

            //calling a method "dublicate"
            dublicate(s, n);
            Console.ReadKey();
        }
    }
}