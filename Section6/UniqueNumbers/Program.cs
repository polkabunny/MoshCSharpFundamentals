using System;
using System.Collections.Generic;

namespace UniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var running = true;
            var inputs = new List<int>();
            while (running)
            {
                Console.WriteLine("Enter a number or type \"Quit\" to exit");
                var userInput = Console.ReadLine();
                try
                {
                    if (userInput.Equals("quit", StringComparison.InvariantCultureIgnoreCase))
                    {
                        running = false;
                    }
                    else
                    {
                        var number = int.Parse(userInput);
                        if (!inputs.Contains(number))
                        {
                            inputs.Add(number);
                        }
                    }
                }
                catch { }
            }
            foreach (var input in inputs)
            {
                Console.Write($"{input} ");
            }
        }
    }
}
