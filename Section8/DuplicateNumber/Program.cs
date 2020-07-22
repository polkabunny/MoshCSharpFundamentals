using System;
using System.Collections.Generic;
using System.Linq;

namespace DuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by a hyphen.");
            var input = Console.ReadLine();
            if (input == null || input.Equals(Environment.NewLine))
            {
                return;
            }

            bool duplicate = false;
            var uniques = new List<int>();
            try
            {
                var split = input.Split('-').Select(p => p.Trim()).ToList();
                var numbers = split.Select(int.Parse).ToList();
                if (numbers.Count >= 2)
                {
                    foreach (var number in numbers)
                    {
                        if (uniques.Contains(number))
                        {
                            duplicate = true;
                            break;
                        }
                        uniques.Add(number);
                    }
                }
            }
            catch { }

            if (duplicate)
            {
                Console.WriteLine("Duplicate");
            }
        }
    }
}
