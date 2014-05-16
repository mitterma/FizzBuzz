using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class FizzBuzz
    {
        public string FizzBuzzOrNumber(int number)
        {
            if (IsDivisibleThree(number) && IsDivisibleByFive(number))
            {
                return "FIZZBUZZ";
            }
            else if (IsDivisibleThree(number))
            {
                return "FIZZ";
            }
            else if (IsDivisibleByFive(number))
            {
                return "BUZZ";
            }
            else
            {
                return number.ToString();
            }
        }
        
        public bool IsDivisibleByFive(int number)
        {
            return (number % 5) == 0;
        }

        public bool IsDivisibleThree(int number)
        {
            return (number % 3) == 0;
        }
    }

}
