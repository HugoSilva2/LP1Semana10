using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void Intro();

        void TakeGuess();

        int GetGuess();

        void CorrectNumber(int attempts);

        void BiggerWrongNumber();

        void SmallerWrongNumber();

        void Final();
    }
}