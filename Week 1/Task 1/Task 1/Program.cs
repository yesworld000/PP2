using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        //creating a function that indicates whether a number is prime or not
        public static bool isprime(int a)
        {
            if (a == 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            //creating integer
            int n = int.Parse(Console.ReadLine());

            string s = Console.ReadLine();

            //creating array and dividing string s to array elements
            string[] arr = s.Split();

            //creating counter which is equal to 0
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                //changing elements of the array to integer
                int c = int.Parse(arr[i]);

                //checking if number is prime, if so adding 1 to counter
                if (isprime(c) == true) cnt++;
            }

                //showing counter to the screen
                Console.WriteLine(cnt);

            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(arr[i]);
                if (isprime(c) == true)
                {
                    // showing all prime numbers
                    Console.Write(c + " ");
                }
            }
                Console.ReadKey();
            }
        }
    }
