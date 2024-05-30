using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCore.Core
{
    public static class FizzStream
    {
        /// <summary>
        /// The Task that runs for FizzBuzz
        /// </summary>
        /// <param name="maxValue">Required: The number to stop at</param>
        /// <param name="minValue">Default 1: The number to start at</param>
        /// <returns></returns>
        public static IEnumerable<string> FizzyStream(int maxValue, int minValue = 1)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            for (int i = minValue; i <= maxValue; i++) {

                yield return fizzBuzz.Calc(i);
                
            }


        }

    }
}
