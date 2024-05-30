using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCore.Models
{

    public class FizzConfig
    {
        public int Number;
        public string ResponseText;
        public FizzConfig(int number, string responseText)
        {
            this.Number = number;
            this.ResponseText = responseText;
        }
    }
}

