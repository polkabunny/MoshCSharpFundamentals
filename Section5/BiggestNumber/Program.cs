using System;
using System.Linq;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var largest = 0;
            Console.WriteLine("Enter a series of numbers separated by commas");
            var userInput = Console.ReadLine();
            try
            {
                var inputs = userInput.Split(',').Select(p => p.Trim()).ToList();
                largest = int.Parse(inputs.First());
                for (int i = 1; i < inputs.Count; i++)
                {
                    var current = int.Parse(inputs[i]);
                    if (current > largest)
                    {
                        largest = current;
                    }
                }
                Console.WriteLine(largest);
            }
            catch (Exception e)
            {
                if (e.GetType() == typeof(NullReferenceException)
                || e.GetType() == typeof(ArgumentNullException)
                || e.GetType() == typeof(InvalidOperationException))
                {
                    Console.WriteLine("Incorrect input");
                }
            }
        }
    }
}
