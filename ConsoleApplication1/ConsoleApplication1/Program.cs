using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        // test 
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (IsDivisibleThree(i) && IsDivisibleByFive(i)) 
                {
                    Console.WriteLine("FIZZBUZZ");
                }
                else if (IsDivisibleThree(i))
                {
                    Console.WriteLine("FIZZ");                    
                }
                else if (IsDivisibleByFive(i))
                {
                    Console.WriteLine("BUZZ");
                }    
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        private static bool IsDivisibleByFive(int number)
        {
            return (number % 5) == 0;
        }

        public static bool IsDivisibleThree(int number)
        {
            return (number % 3) == 0;
        }
    }
}
