using FizzBuzzCore.Core;
using FizzBuzzCore.Models;
using NUnit.Framework.Internal.Commands;
using System.Reflection;

namespace FizzBuzzUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(15, "Fizz, Buzz", true)]
        [TestCase(15, "Fizz, Buzz")]
        [TestCase(3, "Fizz", true)]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz", true)]
        [TestCase(5, "Buzz")]
        [TestCase(9, "Fizz", true)]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz", true)]
        [TestCase(10, "Buzz")]
        [TestCase(1000000007, "1000000007")]
        [TestCase(1000000007, "1,000,000,007", true)]
        public void FizzBuzz_Number_Default_FizzBuzz(int number,  string expected, bool format = false)
        {
            string methodName = MethodBase.GetCurrentMethod().Name;
            Console.WriteLine($"Running Test: {methodName}");
            FizzBuzz fizzBuzz = new FizzBuzz();
            string result = fizzBuzz.Calc(number, formatOutput: format);
            Assert.AreEqual(expected, result);
        }

        [TestCase(9, "Buzzy", "3", "Buzzy")]
        [TestCase(18, "Two, Three", "3", "Three", "2", "Two")]
        [TestCase(30, "Two, Three, Five", "3", "Three", "2", "Two", "5", "Five")]
        [TestCase(31, "31", "3", "Three", "2", "Two", "5", "Five")]
        public void FizzBuzz_Number_Custom_Labels(int number, string expected, params string[] config)
        {
            string methodName = MethodBase.GetCurrentMethod().Name;
            Console.WriteLine($"Running Test: {methodName}");
            List<FizzConfig> configs = new List<FizzConfig>();
            for (int i = 0; i < config.Length; i += 2)
            {
                configs.Add(new FizzConfig(Int32.Parse(config[i]), config[i + 1]));
            }

            FizzBuzz fizzBuzz = new FizzBuzz(configs);
            string result = fizzBuzz.Calc(number);
            Assert.AreEqual(expected, result);
        }


        [TestCase(2000)]
        [TestCase(1000000, 900000)]
        [TestCase(5246,5000)]
        public async Task Test_FizzyStream(int maxValue , int minValue = 1)
        {
            string methodName = MethodBase.GetCurrentMethod().Name;
            Console.WriteLine($"Running Test: {methodName}");
            FizzBuzz fizzBuzz = new FizzBuzz();
            int count = minValue;

            foreach(string fizzy in FizzStream.FizzyStream(maxValue: maxValue, minValue: minValue))
            {
                Assert.AreEqual(fizzy, fizzBuzz.Calc(count));
                count++;
            }
        }


    }
}