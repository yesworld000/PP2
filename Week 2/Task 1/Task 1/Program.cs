using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {

        public static bool palindrome(string s)
        {
            char[] letter = new char[s.Length];
            letter = s.ToCharArray();
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (letter[i] != letter[length - i - 1])
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            string direction = (@"C:\Users\Lenovo\Documents\pp2\Week 2\Task 1\Folder\input.txt");
            string check = System.IO.File.ReadAllText(direction);
            if (palindrome(check) == true)
            {
                Console.Write("YES");
            }
            else Console.Write("NO");

            Console.ReadKey();
        }
    }
}