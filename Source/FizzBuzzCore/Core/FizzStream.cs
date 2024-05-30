using FizzBuzzCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCore.Core
{
    public static class FizzStream
    {

        public static List<FizzConfig> Config = new List<FizzConfig>();

        /// <summary>
        /// The Task that runs for FizzBuzz
        /// </summary>
        /// <param name="maxValue">Default 100: The number to stop at</param>
        /// <param name="minValue">Default 1: The number to start at</param>
        /// <param name="formatOutput">Default false: Format output to include commas </param>
        /// <returns></returns>
        public static IEnumerable<string> FizzyStream(int maxValue = 100, int minValue = 1, bool formatOutput = false)
        {
            FizzBuzz fizzBuzz = new FizzBuzz(Config);
            string outValue = string.Empty;

            for (int i = minValue; i <= maxValue; i++) {
                yield return fizzBuzz.Calc(i, formatOutput: formatOutput);
            }
        }

    }
}
