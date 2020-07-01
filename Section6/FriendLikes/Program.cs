using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FriendLikes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            var names = new List<string>();
            Console.WriteLine("Enter the names of the friends");
            while (running)
            {
                var userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    running = false;
                }
                else
                {
                    names.Add(userInput);
                }
            }

            switch(names.Count)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine($"{names.First()} likes your post.");
                    break;
                case 2:
                    Console.WriteLine($"{names.First()} and {names[1]} like your post.");
                    break;
                default:
                    Console.WriteLine($"{names.First()}, {names[1]} and {names.Count-2} others like your post.");
                    break;
            }
        }
    }
}
