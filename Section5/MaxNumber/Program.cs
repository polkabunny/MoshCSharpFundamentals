using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;

            Console.WriteLine("Please enter the first number");
            var firstInput = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            var secondInput = Console.ReadLine();

            try
            {
                firstNum = int.Parse(firstInput);
                secondNum = int.Parse(secondInput);

                Console.WriteLine(Math.Max(firstNum, secondNum));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("That is not a valid number");
            }
        }
    }
}
