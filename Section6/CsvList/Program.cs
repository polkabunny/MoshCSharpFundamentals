using System;
using System.Collections.Generic;
using System.Linq;

namespace CsvList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
            var userInput = Console.ReadLine();

            var stringList = userInput.Split(',').Select(p => p.Trim()).ToList();
            var numList = new List<int>();
            foreach (var str in stringList)
            {
                try
                {
                    var number = int.Parse(str);
                    numList.Add(number);
                }
                catch { }
            }

            if (numList.Count < 5)
            {
                Console.WriteLine("Invalid List. Please re-try");
            }
            else
            {
                numList.Sort();
                Console.WriteLine($"{numList[0]} {numList[1]} {numList[2]}");
            }
        }
    }
}
