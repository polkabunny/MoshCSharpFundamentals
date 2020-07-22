using System;

namespace NumberOfVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an English word");
            var input = Console.ReadLine();
            var count = 0;
            try
            {
                foreach (var letter in input)
                {
                    if (letter.Equals('a') || letter.Equals('e') || letter.Equals('i') || letter.Equals('o') ||
                        letter.Equals('u'))
                    {
                        count++;
                    }
                }
            } catch {}
            Console.WriteLine(count);
        }
    }
}
