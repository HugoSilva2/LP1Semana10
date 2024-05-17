using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void Intro();

        void CorrectNumber();

        void BiggerWrongNumber();

        void SmallerWrongNumber();

        
    }
}