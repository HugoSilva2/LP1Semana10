using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View : IView
    {
        public void Intro()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public void TakeGuess()
        {
            Console.Write("Take a guess: ");
        }

        public int GetGuess()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public void CorrectNumber(int attempts)
        {
            Console.WriteLine("Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void BiggerWrongNumber()
        {
            Console.WriteLine("Too high! Try again.");
        }

        public void SmallerWrongNumber()
        {
            Console.WriteLine("Too low! Try again.");
        }

        public void Final()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}