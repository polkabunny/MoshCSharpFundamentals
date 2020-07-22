using System;
using System.Globalization;
using System.Linq;

namespace PascalCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words separated by a space");
            var input = Console.ReadLine();
            var textInfo = new CultureInfo("en-gb").TextInfo;
            try
            {
                var split = input.Split(' ').Select(p => p.Trim()).ToList();
                foreach (var word in split)
                {
                    Console.Write(textInfo.ToTitleCase(word));
                }
            } catch {}
        }
    }
}
