using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View : IView
    {
        private readonly int targetNumber;
        private readonly Controller controller;

        public View(int targetNumber, Controller controller)
        {
            this.targetNumber = targetNumber;
            this.controller = controller;
        }

        public void Introduction()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public int TakeGuess()
        {
            int guess;
            bool valid;

            do
            {
                Console.Write("Take a guess: ");

                valid = int.TryParse(Console.ReadLine(), out guess);
                if (!valid)
                {
                    Console.WriteLine(">> Input is not a valid number <<");
                }

            } while (!valid);

            return guess;
        }

        public bool GuessEval(int guess, int attempts)
        {
            if (guess == targetNumber)
            {
                Console.WriteLine(
                    "Congratulations! You guessed the number correctly!");
                Console.WriteLine("Number of attempts: " + attempts);
                return true;
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Too low! Try again.");
                return false;
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
                return false;
            }
        }

        public void Success()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }


    }
}