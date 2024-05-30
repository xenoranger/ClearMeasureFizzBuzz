using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzCore.Models;

namespace FizzBuzzCore.Core
{
    public class FizzBuzz
    {
        public List<FizzConfig> data;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">A List of Numbers and Responses. <br />Default: null which acts as 3 = Fizz and 5 = Buzz </param>
        public FizzBuzz(List<FizzConfig> input = null)
        {
            if (input == null || input.Count < 1)
            {
                data = new List<FizzConfig>();
                data.Add(new FizzConfig(3, "Fizz"));
                data.Add(new FizzConfig(5, "Buzz"));
            }
            else
            {
                data = input;
            }
        }

        /// <summary>
        /// Calculates the given number and returns the configured response
        /// </summary>
        /// <param name="number">The number to calculate</param>
        /// <returns></returns>
        public string Calc(int number, bool formatOutput = false)
        {
            string output = string.Empty;
            var matches = data.FindAll(m => number % m.Number == 0).OrderBy(o => o.Number);

            foreach (var match in matches)
            {
                output += match.ResponseText;
                if(match != matches.Last())
                {
                    output += ", ";
                }
            }

            if (output != string.Empty)
            {
                return output;
            }

            if (formatOutput)
            {
                return number.ToString("N0");
            }
            return number.ToString();
        }



    }


}


