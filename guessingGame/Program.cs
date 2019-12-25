using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;

            while (game)
            {
                Console.WriteLine("Guess a number between 1-10");
                Console.WriteLine("Enter 0 to get instructions");
                string guess = Console.ReadLine();
                int guessNum = Convert.ToInt32(guess);

                if (guessNum == 7)
                {
                    Console.WriteLine("You right nigga");
                }
                else if (guessNum == 0)
                {
                    Console.WriteLine("You guess 1-10 nigga whatchu mean??");
                }
                else if (guessNum == -1)
                {
                    game = false;
                }
                else if (guessNum <= 6)
                {
                    Console.WriteLine("Guess higher");
                }
                else if (guessNum >= 8)
                {
                    Console.WriteLine("Guess lower");
                }

            }
        }
    }
}
