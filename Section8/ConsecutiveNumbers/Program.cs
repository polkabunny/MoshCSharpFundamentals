using System;
using System.Linq;

namespace ConsecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers separated by a hyphen.");
            var input = Console.ReadLine();
            bool consecutive = false;
            try
            {
                var split = input.Split('-').Select(p => p.Trim()).ToList();
                var numbers = split.Select(int.Parse).ToList();
                if (numbers.Count < 2)
                {
                    consecutive = true;
                }
                else
                {
                    var currentNum = numbers[0];
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        if (numbers[i] == currentNum-1 || numbers[i] == currentNum+1)
                        {
                            consecutive = true;
                            currentNum = numbers[i];
                        }
                        else
                        {
                            consecutive = false;
                            break;
                        }
                    }
                }
            }
            catch { }

            if (consecutive)
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not Consecutive");
            }
        }
    }
}
