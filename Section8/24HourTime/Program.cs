using System;
using System.Globalization;

namespace _24HourTIme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time value in the 24-hour time format");
            var input = Console.ReadLine();
            var valid = DateTime.TryParseExact(input, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.NoCurrentDateDefault, out var result);
            if(valid)
            {
                Console.WriteLine("Ok");
            } else
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
