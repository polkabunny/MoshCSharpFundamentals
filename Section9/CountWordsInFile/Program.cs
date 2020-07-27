using System;
using System.IO;

namespace CountWordsInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("File.txt");
            var count = 0;
            try
            {
                var modInput = input.Replace(Environment.NewLine, " ");
                var split = modInput.Split(' ');
                count = split.Length;
            } catch { }
            Console.WriteLine(count);
        }
    }
}
