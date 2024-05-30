using FizzBuzzCore.Core;


    public class Program
    {

        public static async Task Main()
        {



            Console.Clear();
            Console.WriteLine("Hello Nurse");

            foreach(string fizzy in  FizzStream.FizzyStream(Int32.MaxValue))
            { 
                Console.WriteLine(fizzy);
            }

        }


    }
