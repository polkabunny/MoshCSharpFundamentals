using System;

namespace ValidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            
            Console.WriteLine("Please enter a valid number");
            var userInput = Console.ReadLine();

            try
            {
                number = int.Parse(userInput);

                if (number > 0 && number < 10)
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
            catch(NullReferenceException)
            {
                Console.WriteLine("That is not a valid number");
            }
        }
    }
}
