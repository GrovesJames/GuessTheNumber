using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOn = true;
            while (gameOn)
            {
                Game game = new Game();

                while(game.GameFinished == false)
                {
                    game.MakeAttempt();
                }

                Console.WriteLine("Press enter to restart");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
