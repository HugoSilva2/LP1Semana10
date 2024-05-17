using System;

namespace GuessTheNumber
{
    public class Controller
    {
        public void Start(IView view)
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            int targetNumber = random.Next(1, 101);

            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            view.Intro();

            // Game loop
            while (!guessedCorrectly)
            {
                view.TakeGuess();
                guess = view.GetGuess();
                attempts++;

                if (guess == targetNumber)
                {
                    view.CorrectNumber(attempts);
                    guessedCorrectly = true;
                }
                else if (guess < targetNumber)
                {
                    view.SmallerWrongNumber();
                }
                else
                {
                    view.BiggerWrongNumber();
                }
            }

            view.Final();
        }
    }
}