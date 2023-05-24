using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Controller
    {
        private readonly int targetNumber;
        private IView view;

        public Controller(int targetNumber)
        {
            this.targetNumber = targetNumber;
        }

        public void Run(IView view)
        {
            this.view = view;

            int guess;
            int attempts = 0;
            bool guessedCorrectly = false;

            view.Introduction();

            while (!guessedCorrectly)
            {
                guess = view.TakeGuess();
                attempts++;
                guessedCorrectly = view.GuessEval(guess, attempts);
            }

            view.Success();
        }
    }
}