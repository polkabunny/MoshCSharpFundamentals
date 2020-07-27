using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LongestWordInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("File.txt");
            var longestWord = string.Empty;
            try
            {
                Regex pattern = new Regex(@"[,?!.\s]");
                string modInput = pattern.Replace(input, " ");
                var split = modInput.Split(' ');
                foreach (var word in split)
                {
                    if(word.Trim().Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }
            }
            catch { }
            Console.WriteLine(longestWord);
        }
    }
}
