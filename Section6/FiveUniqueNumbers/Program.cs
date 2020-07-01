using System;
using System.Collections.Generic;
using System.Linq;

namespace FiveUniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            var inputs = new List<int>();
            Console.WriteLine("Enter 5 unique numbers");
            while (running)
            {
                var userInput = Console.ReadLine();
                var intInput = int.Parse(userInput);
                if (inputs.Contains(intInput))
                {
                    Console.WriteLine("Please enter a unique number.");
                }
                else
                {
                    inputs.Add(intInput);
                    if (inputs.Count >= 5)
                    {
                        running = false;
                    }
                }
            }

            inputs.Sort();
            foreach (var input in inputs)
            {
                Console.Write($"{input} ");
            }
        }
    }
}
