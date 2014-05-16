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
            FizzBuzz fizzbuzz = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzbuzz.FizzBuzzOrNumber(i));
            }
            Console.ReadLine();
        }
    }
}
