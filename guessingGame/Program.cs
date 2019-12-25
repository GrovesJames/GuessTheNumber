using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int attempts = 4;
            bool game = true;

            while (game)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("--------------------");
                Console.WriteLine("\nGuessing game!\n");
                Console.WriteLine("Guess a number between 1-10");
                Console.WriteLine("Enter 0 to get instructions\n\n");
                Console.WriteLine("--------------------");
                Console.WriteLine("--------------------");

                attempts = attempts - 1;
                if (attempts == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Thanks for trying! Game over.");
                }
                else
                {
                    Console.WriteLine("\nYou have " + attempts + " attempts remaining!\n\n");
                }
                string guess = Console.ReadLine();
                int guessNum = Convert.ToInt32(guess);
                Console.Clear();

                if (guessNum == randomNumber)
                {
                    Console.Clear();
                    Console.WriteLine("You're correct!");
                    Console.ReadLine();
                    game = false;
                }
                else if (guessNum == 0)
                {
                    Console.WriteLine("You guess 1-10, don't overthink it!\n\n");
                }
                else if (guessNum == -1)
                {
                    game = false;
                }
                else if (guessNum <= randomNumber - 1)
                {
                    Console.WriteLine("Guess higher\n\n");
                }
                else if (guessNum >= randomNumber + 1)
                {
                    Console.WriteLine("Guess lower\n\n");
                }
            }
        }
    }
}
