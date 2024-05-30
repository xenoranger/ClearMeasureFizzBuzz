using FizzBuzzCore.Core;
using FizzBuzzCore.Models;

    public class Program
    {

        public static async Task Main()
        {

            Console.Clear();
            Console.WriteLine("Hello Nurse");

        FizzStream.Config.Add(new FizzConfig(8, "Eight"));
        FizzStream.Config.Add(new FizzConfig(7, "Seven"));
        FizzStream.Config.Add(new FizzConfig(5, "Five"));

        foreach (string fizzy in  FizzStream.FizzyStream(maxValue: 200000,formatOutput: true))
            { 
                Console.WriteLine(fizzy);
            }

        }


    }
