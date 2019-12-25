using System;
using System.Collections.Generic;
using System.Text;

namespace guessingGame
{
    class Game
    {
        public int Attempts { get; set; }
        public string Answer { get; set; }
        public bool GameFinished { get; set; }

        public Game()
        {
            Attempts = 3;
            Answer = GetAnswer();
            GameFinished = false;
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");
            Console.WriteLine("\nGuessing game!\n");
            Console.WriteLine("Guess a number between 1-10");
            Console.WriteLine("Enter 0 to get instructions\n\n");
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------");

        }

        private string GetAnswer()
        {
            Random random = new Random();
            string answer = random.Next(1, 11).ToString();

            return answer;
        }

        public void MakeAttempt()
        {
            Console.WriteLine("You have " + this.Attempts + " attempts remaining!");
            string attempt = Console.ReadLine();

            Attempts = Attempts - 1;
            Console.Clear();
            CheckAttempt(attempt);
        }

        public void CheckAttempt(string attempt)
        {
            int NumGuess = Convert.ToInt32(attempt);
            int NumAnswer = Convert.ToInt32(Answer);
            if(attempt == Answer)
            {
                Console.WriteLine("You win! You guessed the correct answer.");
                GameFinished = true;
            }
            else if (Attempts == 0)
            {
                Console.WriteLine("You lost! Thanks for playing!");
                GameFinished = true;
            }
            else if (NumGuess >= NumAnswer + 1)
            {
                Console.WriteLine("Guess lower");
            }
            else if (NumGuess <= NumAnswer - 1)
            {
                Console.WriteLine("Guess higher");
            }
        }
    }
}
