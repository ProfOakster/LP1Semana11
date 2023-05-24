using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {
        void Introduction();
        int TakeGuess();
        bool GuessEval(int guess, int attempts);
        void Success();
    }
}