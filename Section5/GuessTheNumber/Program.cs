using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var answer = random.Next(1, 10);

            var correctGuess = false;
            var guessesRemaining = 4;
            while (guessesRemaining > 0 && !correctGuess)
            {
                Console.WriteLine($"Guess the number! You have {guessesRemaining} guesses left");
                var input = Console.ReadLine();
                try
                {
                    var guess = int.Parse(input);
                    if (guess == answer)
                    {
                        correctGuess = true;
                        Console.WriteLine($"You won - the answer was {answer}");
                    }
                }
                catch { }
                guessesRemaining--;
            }

            if (!correctGuess)
            {
                Console.WriteLine($"You lost - the answer was {answer}");
            }
        }
    }
}
