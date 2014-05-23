using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {

        [TestMethod()]
        public void IsDivisibleByFiveTest()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();

            Assert.IsTrue(fizzbuzz.IsDivisibleByFive(5));
            Assert.IsFalse(fizzbuzz.IsDivisibleByFive(4));
        }

        [TestMethod()]
        public void FizzBuzzOrNumberTest()
        {
            FizzBuzz fizzbuzz = new FizzBuzz();

            Assert.AreEqual("8", fizzbuzz.FizzBuzzOrNumber(8));
            Assert.AreEqual("FIZZ", fizzbuzz.FizzBuzzOrNumber(3));
            Assert.AreEqual("BUZZ", fizzbuzz.FizzBuzzOrNumber(5));
            Assert.AreEqual("FIZZBUZZ", fizzbuzz.FizzBuzzOrNumber(15));

            Assert.AreEqual("FIZZ", fizzbuzz.FizzBuzzOrNumber(13));
            Assert.AreEqual("FIZZ", fizzbuzz.FizzBuzzOrNumber(73));

            Assert.AreEqual("FIZZ", fizzbuzz.FizzBuzzOrNumber(33));

            Assert.AreNotEqual("25", fizzbuzz.FizzBuzzOrNumber(25));
        }
    }
}
