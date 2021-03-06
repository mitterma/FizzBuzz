﻿using System;
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
            if (IsDivisibleByThree(number) && IsDivisibleByFive(number))
            {
                return "FIZZBUZZ";
            }
            else if (IsDivisibleByThree(number) || IsContainsThree(number))
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

        public bool IsDivisibleByThree(int number)
        {
            return (number % 3) == 0;
        }

        public bool IsContainsThree(int number)
        {
            if (number.ToString().Contains("3"))
            {
                return true;
            }
            
            return false;
        }
    }

}
