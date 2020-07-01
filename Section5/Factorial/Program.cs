using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var total = 1;
            Console.WriteLine("Enter a number or \"ok\" to exit");
            var userInput = Console.ReadLine();
            try
            {
                var currentNum = Math.Abs(int.Parse(userInput));
                while (currentNum > 0)
                {
                    total *= currentNum;
                    currentNum--;
                }
                Console.WriteLine(userInput + "! = " + total);
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
