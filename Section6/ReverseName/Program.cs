using System;
using System.Linq;

namespace ReverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            var input = Console.ReadLine();
            try
            {
                var array = input.ToCharArray().Reverse();
                foreach (var character in array)
                {
                    Console.Write(character);
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("You need to enter something!");
            }
        }
    }
}
