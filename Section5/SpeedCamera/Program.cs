using System;

namespace SpeedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            int speed;
            
            Console.WriteLine("Please enter the speed limit");
            var limitInput = Console.ReadLine();
            Console.WriteLine("Please enter the speed of a car");
            var speedInput = Console.ReadLine();

            try
            {
                limit = int.Parse(limitInput);
                speed = int.Parse(speedInput);

                var difference = limit - speed;

                if (difference >= 0)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    var amountOfSpeeding = Math.Abs(difference) / 5;

                    if (amountOfSpeeding >= 12)
                    {
                        Console.WriteLine("License suspended");
                    }
                    else if (amountOfSpeeding == 0)
                    {
                        Console.WriteLine("Ok");
                    }
                    else
                    {
                        Console.WriteLine(amountOfSpeeding);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Not a valid number");
            }
        }
    }
}
