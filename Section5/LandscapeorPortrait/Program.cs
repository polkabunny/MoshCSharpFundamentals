using System;

namespace LandscapeorPortrait
{
    class Program
    {
        static void Main(string[] args)
        {
            int width;
            int height;

            Console.WriteLine("Please enter the width");
            var widthInput = Console.ReadLine();
            Console.WriteLine("Please enter the height");
            var heightInput = Console.ReadLine();

            try
            {
                width = int.Parse(widthInput);
                height = int.Parse(heightInput);

                if (width <= 0 || height <= 0)
                {
                    Console.WriteLine("Non-existant");
                } else if (width > height)
                {
                    Console.WriteLine("Landscape");
                } else if (width < height)
                {
                    Console.WriteLine("Portrait");
                } else if (width == height)
                {
                    Console.WriteLine("Square");
                }
            }
            catch
            {
                Console.WriteLine("Not valid number");
            }
        }
    }
}
