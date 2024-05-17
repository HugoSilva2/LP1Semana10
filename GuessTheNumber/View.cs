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

        public void CorrectNumber()
        {

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