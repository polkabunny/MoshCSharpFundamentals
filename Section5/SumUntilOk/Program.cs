using System;

namespace SumUntilOk
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            var count = 0;
            while (running)
            {
                Console.WriteLine("Enter a number or \"ok\" to exit");
                var userInput = Console.ReadLine();
                try
                {
                    if (userInput.Equals("ok", StringComparison.InvariantCultureIgnoreCase))
                    {
                        running = false;
                    }
                    else
                    {
                        var currentNum = int.Parse(userInput);
                        count += currentNum;
                        Console.WriteLine("Count: " + count);
                    }
                }
                catch (Exception e)
                {
                    if (e.GetType() == typeof(ArgumentNullException)
                        || e.GetType() == typeof(FormatException)
                        || e.GetType() == typeof(OverflowException))
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
            }
        }
    }
}
